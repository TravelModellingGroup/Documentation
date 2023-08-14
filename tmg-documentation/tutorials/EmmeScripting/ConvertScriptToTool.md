# Convert Script To Tool

With our completed script from the section [Writing A Script](WritingAScript.md) we can now convert
that script into a tool.  For reference the script is below:

```python
import six
m = inro.modeller.Modeller()
databank = m.emmebank
scenario = databank.scenario(1)
network = scenario.get_network()

delta_x = 10_000
delta_y = -20_000

# Update the nodes
for node in network.nodes():
    node.x = node.x + delta_x
    node.y = node.y + delta_y

# Update the vertices
for link in network.links():
    # Get a copy of the vertices
    vertices = link.vertices
    for i in range(len(link.vertices)):
        vertices[i] = (vertices[i][0] + delta_x,  vertices[i][1] + delta_y)
    # You must assign the list back to vertices since it is a copy
    link.vertices = vertices

# And finally save the network
scenario.publish_network(network)
print("Done")
```

The first thing we will do is start with the basic template of a tool:

```python
import inro.modeller

class MoveNetwork(inro.modeller.Tool()):

    def __init__(self):
        pass

    def page(self):
        pb = inro.modeller.ToolPageBuilder(
            self,
            title="Move Network",
            description="Move the network.",
            runnable=True,
            branding_text="Example",
        )
        return pb.render()

    def run(self):
        pass

```

This initial shell gives us the name of our tool, `MoveNetwork` and creates the initial three
member functions.  The `__init__` function will be called when the tool is loaded by modeller.
`page` will be called then and can be used to provide Modeller with an interface for the tool.
For the moment that text is going to be fixed to a simple title. `run` will be called when the
user presses the `Run` button in Modeller's interface.

We can now then integrate in our script:

```python
import six
import inro.modeller

class MoveNetwork(inro.modeller.Tool()):

    Scenario_Number = inro.modeller.Attribute(int)
    Delta_X = inro.modeller.Attribute(float)
    Delta_Y = inro.modeller.Attribute(float)

    def __init__(self):
        self.Scenario_Number = 1
        self.Delta_X = 0
        self.Delta_Y = 0

    def page(self):
        pb = inro.modeller.ToolPageBuilder(
            self,
            title="Move Network",
            description="Move the network.",
            runnable=True,
            branding_text="Example",
        )
        return pb.render()

    def run(self):
        m = inro.modeller.Modeller()
        databank = m.emmebank
        scenario = databank.scenario(self.Scenario_Number)
        network = scenario.get_network()
        
        delta_x = self.Delta_X
        delta_y = self.Delta_Y
        
        # Update the nodes
        for node in network.nodes():
            node.x = node.x + delta_x
            node.y = node.y + delta_y
        
        # Update the vertices
        for link in network.links():
            # Get a copy of the vertices
            vertices = link.vertices
            for i in range(len(link.vertices)):
                vertices[i] = (vertices[i][0] + delta_x,  vertices[i][1] + delta_y)
            # You must assign the list back to vertices since it is a copy
            link.vertices = vertices
        
        # And finally save the network
        scenario.publish_network(network)
        print("Done")

```

Given this structure our next goal is to start allowing the user modify our variables.  `delta_x`, `delta_y`, and
the scenario number are good candidates to move into things the user can set.

