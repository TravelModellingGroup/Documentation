# **Add the toolbox to EMME**
The `ExportSubareaTool` is used to export the road network from a regional network, the `ExportSubareaTool` extracts the traversal demand matrices, link volumes, turn volumes, transit network (optional), and traffic and transit traversal demand matrices (optional). To learn more about the subarea network, visit the [TMG Export Subarea Tool Documentation](https://tmg.utoronto.ca/doc/2.0/tmgtoolbox2_emme/tools/Export/ExportSubareaNetwork.html).

In this workshop, we are going to learn how to use the TMG `ExportSubareaTool` to export a subarea from a regional network.

## **Add the toolbox to Emme Modeller**

a.	Open Emme modeller

<figure>
    <img src="images/open_modeller.png"
         alt="Open Modeller in Emme Tools" style="width:600px;" />
    <figcaption text-align="center">Figure 4: Modeller in Emme Tools</figcaption>
</figure>

b.	Click “Add a toolbox…”

 <figure>
    <img src="images/add_toolbox.png"
         alt="Add Downloaded TMG Toolbox" style="width:600px;" />
    <figcaption text-align="center">Figure 5: Add Downloaded TMG Toolbox</figcaption>
</figure>

c.	Choose the .mtbx file path, enter a title and set the namespace to “tmg”
 
  <figure>
    <img src="images/set_toolbox_file_path.png"
         alt="Set file path, title and namespace " style="width:400px;" />
    <figcaption text-align="center">Figure 6: Set new toolbox file path, title and namespace </figcaption>
</figure>

d.	Check to confirm the toolbox has been added and close the modeller
 
 <figure>
    <img src="images/confirm_toolbox_added.png"
         alt=" Verify TMG Toolbox is added" style="width:600px;" />
    <figcaption text-align="center">Figure 7: Verify TMG Toolbox is added</figcaption>
</figure>

## **Launch Emme Notebook**

a. Launch EMME notebook
  <figure>
    <img src="images/launch_notebook.png"
         alt="Launch EMME notebook" style="width:400px;" />
    <figcaption text-align="center">Figure 8: Launch EMME notebook </figcaption>
</figure>

b. Create a new Python notebook and rename

<figure>
    <img src="images/create_and_rename_notebook.png"
         alt="Create and rename a new python EMME notebook" style="width:400px;" />
    <figcaption text-align="center">Figure 8: Create and rename a new python EMME notebook </figcaption>
</figure>

c. You should get the below page (here we renamed to TMG Workshop – Export Subarea)
 
<figure>
    <img src="images/notebook_ready.png"
         alt="Notebook ready for coding" style="width:600px;" />
    <figcaption text-align="center">Figure 8: EMME notebook ready for coding </figcaption>
</figure>

d. We are ready to start writing the subarea tool JSON parameters.