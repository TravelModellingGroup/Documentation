# Estimation


TMG’s Estimation is a generalized framework for estimating models.  It is based on XTMF.Networking to provide its underlying communication between host and clients.  This means that in order to utilize the framework the tasks will be broken down into a single host and multiple client model systems.  The host client is created by using XTMF GUI and the clients are run by the XTMF.RemoteClient.exe program and target the Host machine.  The following subsections will describe the process for using the Estimation Framework.

## Understanding Relative Parameter Space

Relative parameter space is an N-Dimensional hyper cube where there are N parameters.  Zero is defined as the minimum real value, and one is the maximum value.  In this way we can standardize the distances between two points to make sure larger magnitude parameters do not become dominant factors.  Some AIs will use this be default, especially newer AIs, and older ones have been retrofitted to use this with a Boolean parameter.  It is recommended to use relative parameter space whenever possible.

## Building an Estimation Model System

To build an estimation model system you will first need to start with an EstimationHost module.

The next select an artificial intelligence.  In the following section we will describe the different AI’s available in the best estimation framework.  The AI is responsible for selecting the different parameters to test for.

The Client Model System is the client side of the estimation framework.  Remote Clients will all execute the client model system.  Inside of the client model system a module that computes a fitness function is required.  Depending on what model system you are running a different module is required.

Currently there is no generic solution for fitness evaluation however this documentation will explain how to build a module in order to accomplish this.

The Host Model System is an optional model system that will execute on the host.  This model system is mostly used for preparing data and setting up file transfers.

The parameter loader is designed to load in the parameter space from file.  The specification of that file will be described in full in its following section.

The result file is a file location in which you wish to save the results and parameters for each test performed.  This file will contain which generation each parameter set is from, the value as evaluated by the client, and each parameter and the value assigned by it.


## Choosing an AI

The choice of AI’s is a very important part in the success of an estimation.  Built into the TMG Estimation Framework are multiple different artificial intelligence algorithms that are optimized for different purposes.  For most purposes internally we use the Particle Swarm Optimization algorithm however, many different AI’s have been included in the standard package.  TMG will continue to add more AI’s into the standard package as newer research can be incorporated.  For logit based models the Gradient AI provides very strong results.  For discrete choice models Gradient AI’s easily get caught in local maximums/minimums.  A traditional Genetic Algorithm (GA) is also included.  It was used extensively until the Particle Swarm Optimization (PSO) algorithm was included into the estimation framework which produced better results far faster than the GA.

In addition some special purpose AI’s have been included to facilitate running validation model systems such as ‘Execute Given Parameters’ which lets you quickly execute the results from another estimation run.  Typically sorting for the best run first so you can get more data.  In this model system we typically output our confusion matrix or compute rho2’s for GTAModel’s mode choice.

All of TMG’s AIs that contain a random element will have a parameter to set the random seed.  If an estimation is run twice with the same random seed the exact same parameters will be explored (assuming the clients return the same fitness the same).  You can explore a different random search by changing this value.


### Gradient AI

The gradient algorithm in the estimation framework is an approximation algorithm that takes an initial random position in relative parameter space.  For each generation a gradient is computed for each dimension and then the kernel space is moved with respect to each dimension in order to compute the next generation.  The algorithm can be switched between gradient descent and ascent by changing the ``Maximize`` parameter between true and false.

The ``Error factor`` parameter is used to convert the gradient into the amount of distance that the kernel will move in relative space for each dimension.

The ``Momentum Factor`` parameter is used to apply the momentum from the previous iteration to the current iteration in order to help move past local minimums.  This value should be between 0 and 1 where 0 means ignore previous generations and 1 where only the previous iteration is considered.  A value of 1 should never be considered for use.

The ``**Whisker Size`` parameter is used in order to approximate the derivative for each dimension.  The whisker is the amount of distance in relative space to move around the kernel in the dimension in order to approximate the derivative.  If the whisker size is too small the derivate could not be large enough to detect any differences.  This is especially true in discrete choice models.  If a whisker size is too large then local minimums/maximums could be missed entirely since the approximation will be weaker.

One of the disadvantages of the Gradient AI is that it is complicated to calibrate, and depending on the number of parameters can require many tests between kernel updates.  Each generation requires two tests for each parameter in order to approximate the derivate and an additional test for the kernel itself.  Another complication is the calibration of the Error Factor, and Whisker Size parameters.  If you Whisker size is too small the derivative can become less stable depending on the fitness function.  Also the Error factor will need to be calibrated in order to convert the differences into movement in parameter space.  This is one of the primary reasons TMG tries avoids this AI in recent work in favour of Particle Swarm Optimization.




### Genetic AI

Genetic AI is a traditional genetic algorithm including niching.  Genetic Algorithms (GAs) are very good at traversing chaotic (many local maximums) parameter spaces.  The base algorithm for each subsequent generation is computed by running the niche elimination, selection, cross, and mutation algorithms.  We highly recommend setting ``Percent Distance`` to true to simplify the calculation especially when the magnitudes between parameters differ greatly.

For the first generation parameters are assigned randomly in parameter space for each parameter set in the population.  Each generation afterwards is generated using the following processes.

One of the problems with a traditional GAs is the tendency to converge too quickly.  One of the remedies for this is the niching algorithm.  The niching algorithm runs as follows, first sort the parameter sets in the population for the best to worst value.  Then starting at the best parameter set moving towards the worst we search all parameter sets worse than our current position.  If the other parameter set is closer than the ``Distance`` parameter then it is included in the current parameter’s niche.  In each niche there is a maximum number of parameter sets that are allowed, in our case the parameter ``Niche Capacity``.  Parameter sets worse than the maximum number are removed from the candidates for the next step, selection.

The next step in a genetic algorithm is the process of selection.  Selection is the taking parameter sets from the previous generation and picking two of them to produce a child for the next generation.  For this selection algorithm we select the remaining parameters based on the ``Cross Exponent``.  A random number is generated between zero and one and is then raised to the power of the Cross Exponent and then multiplied by the size of the surviving population after the niching process, let’s call this value X.  We then round X down to the nearest integer value, and the parameter set at that position is selected.  This means that the greater the value of the ``Cross Exponent`` the more likely it is to pick a value closer to the best parameter set.  A Cross Exponent of one gives us a uniform distribution, and values less than one gives us a higher probability of selecting a parameter set towards the worst.  We find values between one and two work best.  Two parameters are selected in order to continue, if the two parameters were the same the next parameter is used instead.

Once two parameters have been selected we first run the cross algorithm then the mutation algorithm to produce the child parameter set.  The cross algorithm works by randomly producing a new parameter set by randomly picking each parameter from its parents.  After the new parameter set is formed we mutate a random number of the child’s parameters.  ``Mutation Probability`` is used as the expected value of parameters to mutate.  Once we know how many parameters we will mutate we randomly select a parameter and change it.  The parameter Max Mutation defines the maximum amount the parameter is allowed to change and Mutation Exponent gives a curve to the probability of how far a parameter is moved.  Similar to how selection works, a random number is generated, then is raised to the power of the Mutation Exponent, and is then multiplied by the ``Max Mutation``.  Another random value is computed to determine if the value should increase or decrease.  This result is then added to the current parameter and then clamped so it remained between the minimum and maximum values for the given parameter.  This process is repeated for the rest of the parameters to change resulting in the child parameter set that is added to the next generation.

The ``Population Size`` parameter sets how many different evaluations will be done per generation.  Selection is used to fill the next generation with the exception of Reseed Size parameters that are randomly generated like in the first generation.

One of the advantages, and disadvantages is that the GA has many parameters to tune it.  Some experimentation is required to readily get good results.  Make sure to set the Maximize parameter true if you wish to maximize the fitness function and to false to minimize.


### Particle Swarm Optimization (PSO)

Particle Swarm Optimization (PSO) algorithms are a modern variation of the traditional genetic algorithm.  At TMG this is currently the most estimation runs.  Unlike GAs PSOs do not bread new parameter sets to produce subsequent generations.  Instead each of the parameter sets, called particles in literature, are updated between generations in order to produce the next set of tests.  Initially as with traditional GAs, particles are randomly distributed in parameter space.  In addition however, the particles are given random velocities in each dimension.  TMG’s PSO will use relative parameter space exclusively for its calculations.

For subsequent generations the PSO updates each particle by first computing a new velocity which will at the end be added to the particle’s position.  First, the Momentum term is used to see how much velocity is continued to be used from the previous generation, this should be a value between zero and one where zero will ignore the previous velocity and one will keep all of the velocity of the previous generation.  Typical values are between 0.3 and 0.7 for this term.  The rest of the terms will use a random number for each parameter in order to apply its effect upon velocity.
Best Parameter Weight is a term that remembers where the best parameter that this particle has encountered itself and applies a pull towards it.  This value is typically negative to actually apply a push away from the best value it has encountered.  This term is included to help push past flat planes in hyper parameter space where the fitness function in a local space returns the same value.  As with the remainder of the terms the distance between the best point and the current point is computed and the random number is multiplied against the Best Parameter Weight parameter to add to the velocity.

``Globally Optimal Weight`` is another traditional PSO term that provides a pull towards the best value found across all generations.  As with the Best Parameter Weight a random number is generated, the distance computed, and the velocity updated with the addition of the random term multiplied by the distance.
Generation Optimal Weight is a newer term to PSO’s, researched heavily in 2014, which has been shown to further improve the ability of PSO’s to avoid being trapped in local minimums.  It is applied exactly like the Global Optimal term with the exception that the optimal point is selected only from the current generation.  This gives it the ability to have generational instability.

Once the velocity has been finalized the particle’s position is moved accordingly.  If the particle falls out of the bounds of parameter space, the particle is clamped to the minimum/maximum of that dimension.  In addition we have also implemented a bounce, where the velocity in that dimension is inversed, to help give the particle a push from edge cases.  This was required to help avoid the case where particles would become trapped to the edges of certain dimensions due to having a great velocity.

The parameter Swarm Size is used to tell the AI how many particles you wish to have.  One of the advantages of a PSO over traditional GA’s is the ability to have a much smaller population allowing the algorithm to run much faster.  Different problems require a different number of parameters and knowing the right number is a bit of an art.  You should at least have one particle per remote client, and if you are to add more, in multiples of your number of clients to reduce he synchronization time between generations.  The more particles you use typically the less generations are required and less time is spent finalizing the generation.  If you have too few generations however the algorithm will not be able to take enough steps to tune the final result well.


## Setting up Parameters

One of the most important parts of estimation is setting what which parameters you want that AI to tune are.  In the TMG Estimation Framework currently only floating point parameters are accepted.  Using the ‘Basic Parameter Loader’ a plain text XML file is used to load in parameters.

Below is an example parameter file:

```xml
<Root>
    <Parameter Minimum="-0.25" Maximum="-0.001">
       <Parameter ParameterPath="Auto Drive.ProfessionalTravelCostFactor" />
       <Parameter ParameterPath="Shared Modes.Passenger.ProfessionalTravelCostFactor" />
       <Parameter ParameterPath="Other Modes.Carpool.ProfessionalTravelCostFactor" />
    </Parameter>
    <Parameter ParameterPath="Other Modes.Bicycle.TravelTimeFactor" Minimum="-0.4" Maximum="0" />
</Root>
```

To begin with everything is contained within a Root tag.  There are two types of Parameter tags, the first allows us to bind together different variables, and the second is for just a single variable.  The ParameterPath attribute is used for linking the parameter to the model.  For example "Other Modes.Bicycle.TravelTimeFactor" would, starting from the client model system’s root module, first look at the “Other Modes” list inside of V4 and find the Bicycle module.  Inside of Bicycle it would then search for the “TravelTimeFactor” parameter and bind to it.  In this way we are able to bind to any parameter inside of the model system regardless of what type of model system we are trying to estimate.  Below is an example model system showing "Other Modes.Carpool.ProfessionalTravelCostFactor".

As you see the path name uses the names used in the model system structures for the path, not the name of the modules.  If two modules at a given level have the same name, the path will be undefined so make sure to have unique names along each path that you wish to estimate.
