Programming with XTMF.Networking
###########################################################

Creating Your Host
----------------------------------------------------------
In order for an XTMF.Networking.IHost to be initialized for your model system the root module will need to create a public variable/property with that type.  XTMF’s that support creating network hosts (XTMF.GUI) will initialize the host and setup your module’s reference to it.  Just like any other parameter or sub module will not be available during the constructor.  Sometimes you will also want to include a constructor in your Root Module that has an ‘XTMF.IConfiguration’ parameter.  Typically you will want to save this for later so you can do things such as adding Progress Reports for your clients so you can observe them from your host.

Example code can be found at:

https://github.com/TravelModellingGroup/XTMF/blob/master/Code/XtmfSDK/MyHostModule.cs

Creating Your Client
----------------------------------------------------------
In order for an ‘XTMF.Networking.IClient’ to be initialized for your model system the root module will need to create a public variable/property with that type.  XTMF’s that support creating network clients
(XTMF.RemoteClient) will initialize the client and setup your module’s reference to it.  Just like any other parameter or sub module will not be available during the constructor.

In the Runtime Validation you will need to check to see if your model system was created with a client or not, this can allow you to build modules that can optionally use the networking infrastructure or just run stand alone.

This code is available at: https://github.com/TravelModellingGroup/XTMF/blob/master/Code/XtmfSDK/MyClientModule.cs


Using Custom Messages with the Host
----------------------------------------------------------
Custom messages are used to pass model system dependent data between host and clients.  With regard to the Host, in order to send a message it will need to specify which remote XTMF to send the message to.

To send a custom message you need to register a ‘CustomSender’ and register it to a custom message number.  You can think of these custom message numbers like Socket ports, they let XTMF route the messages to the handlers that you specify behind the scene.  They are full-duplex, so instead of our example of having sending done on custom message number 1 and receiving on 2 they could have both been on 1.  The custom message sender is supposed to take in an object, look at the client if needed and then build a message and write it to the ‘outputStream’.  After the custom message sender finishes the data is then compiled together with the custom message header sent to the remote XTMF for decoding.

Receiving messages is similar to sending messages; however it has a two part decoding process.  In the first part the custom message receiver is invoked.  It takes in the custom message payload and which client it came from.  Its job is to then create an object (probably decoded from the client’s message).  This object is then transported out to the second stage of processing.  The second part is the custom message handler.  It is important to note that you can have multiple custom message handlers.  Handlers are tasked with the job of taking the object and then carrying out the logic associated with it.  For example, if the message was a set of parameters to use to estimate a model it could create a new task to be processed for those parameters.

While it might sound much easier to just use the custom message handler to process your data, please do not as it will block the host from interacting with that client until the message has been fully processed leading to possible disconnection of that client.  Similarly, with sending messages the same problem can apply as it will not be able to ask for progress updates while you are building your custom message.



Using Custom Messages with the Client
----------------------------------------------------------
All of the same logic from using custom messages from the host also apply to using them from the client side.

The primary difference is that there is only one host, so no remote XTMF reference is required to send the messages as such they are not included in the parameters.  Make sure to not do too much processing in the senders/receivers to avoid locking the networking module.


Host Events
----------------------------------------------------------
The ‘XTMF.Networking.IHost’ also provides a number of events for connected remote clients.

Typically you will not need to implement many of these however, new clients and disconnecting clients are very important in many cases.  For ‘client run complete’ and ‘all model system runs complete’ these refer to a second way of imagining how a host should operate.  You can optionally give the model system many different model systems to execute, and as clients connect / finish it will send them new model systems to run.  Typically once a client starts up their model system they will not want to stop running until the whole system has completed and to run different configurations a custom message is sent.  This allows you to load data once and then run as many parameters as you want instead of reloading each time and also avoid the overhead of sending model systems across the network and building them on the client side.

Again please make sure to not do too much processing inside these events as they lock the host from processing any more messages from that specific client.


Looking at Connected Remote XTMF Instances
----------------------------------------------------------
When you want to do something that requires you to know about what remote XTMF’s are connected you need to lock the host so you have a constant state.

.. code-block:: c#
        :linenos:

        private void LookAtConnectedClients()
        {
            lock ( this.Host )
            {
                foreach ( var client in this.Host.ConnectedClients )
                {
                    // Access the client here
                }
            }
        }


XTMF.Networking.MessageQueue<T>
----------------------------------------------------------
XTMF also includes a thread-safe message queue to help with reducing the time you spend in your event handlers and your message handlers.

.. code-block:: c#
        :linenos:

        private MessageQueue<int> Jobs;
        private volatile bool exit = false;
        private void RunJobs()
        {
            using ( Jobs = new MessageQueue<int>() )
            {
                while ( !exit )
                {
                    var message = Jobs.GetMessageOrTimeout(200);
                    if(message != default(int))
                    {
                        // Process your message here
                    }
                }
            }
        }

The code above shows how you can poll the queue to see if a new job is ready.  If the MessageQueue’s type was a class as opposed to a structure, you could just test for null.  With this call, if there is nothing on the queue for 200 milliseconds it will return the default value for the type.  If there was at least one message the first one will be returned.

.. code-block:: c#
        :linenos:

        private void CustomMessageHandler(object data, IRemoteXTMF client)
        {
            if ( data is int )
            {
                this.Jobs.Add( (int)data );
            }
         }


Returning a Status Message
----------------------------------------------------------
In order to return a status message your module just needs to override the ‘ToString’ method on your module.  By default Model System Templates will have the status of “Running Model System”.  If you override it, you will be able to control the message.  Please keep it short; the provided GUI will chop off the end of the message if it gets too long.
