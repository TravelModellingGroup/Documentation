# Writing A Script

For this tutorial we are going to write a script that move the whole transit network.

## Starting Point

Building on what we learned from the [EMME Class Structure](EMMEClassStructure.md) step we have the following code
to start building our script.

```python
import six
m = inro.modeller.Modeller()
databank = m.emmebank
scenario = databank.scenario(1)
network = scenario.get_network()
# Our code goes here
# ...
# And finally save the network
scenario.publish_network(network)
print("Done")
```

In order to move the nodes we need to pick how fare we want to move the nodes.  Since that we want to move
the network might change, we are going to set those amounts as variables.

```python
delta_x = 10
delta_y = -20
```

With that set our next step is to iterate through each node in the network.  In order to do that we are going
to use a `for` loop.  To start with we will create that `for` loop that goes through each node and then do nothing.
To do nothing in a for loop (or an if statement) you can use that `pass` keyword.

```python
for node in network.nodes():
  pass
```

Our next step is to apply the transformation to each node.

```python
for node in network.nodes():
    node.x = node.x + delta_x
    node.y = node.y + delta_y
```

Putting it all together we now have:

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

# And finally save the network
scenario.publish_network(network)
print("Done")
```

If we run the code something looks off though.  If our network contains vertices we need to also move them.
To do this we will loop through all of the links in the network and get a copy of their vertices.  We will
then move each vertex and apply it back to the link.

```python
for link in network.links():
    # Get a copy of the vertices
    vertices = link.vertices
    for i in range(len(link.vertices)):
        vertices[i] = (vertices[i][0] + delta_x,  vertices[i][1] + delta_y)
    # You must assign the list back to vertices since it is a copy
    link.vertices = vertices
```

Putting it all together again we now have the working script:

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

## Next Steps

Now that we have a working script the next step is to [convert that script](ConvertScriptToTool.md) into a tool
that can be integrated into an EMME Toolbox.