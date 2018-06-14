# Preface

The GTHA system of transit fares largely comprises individual agencies with an initial boarding fare and free transfers intra-agency. It unusually complex and very difficult to model using Emme, which lacks the ability to apply initial fare costs selectively.
Prior work has experimented with the idea of using a “hyper-network” to model fares. The concept is theoretically sound, however its implementation was inflexible and utilized centroid connectors as key elements in its implementation. This feature made it difficult to apply to different zone systems, of which there are several in the region. 

Additionally, it is very advantageous to be able to not only model the current state of fares in the GTHA, but to also be able to test alternate fare scenarios. Therefore, it is desirable to create a general solution to problem; one that can be used to model both existing and alternate systems and that is not constrained to work with only one zone system.

TMG has developed a procedure to generate the base fare-based transit network (FBTN), implemented as a Modeller Tool inside of the TMG Toolbox: Network Editing -> FBTA -> Create from schema.

The remainder of this document split into four parts. The first part describes the structure of the resulting hyper-network, and how it is generated using a Modeller Tool. The second part details the input fare schema file, and how it is applied by the Tool. The third part provides some additional detail on usage and performance. The last part describes how the 2012 base fare schema was compiled, its sources, assumptions, and behaviours.

## Version History

    * Original published June 6, 2014
    * Updated on June 10, 2015 to include new Station Group / Centroid / Psuedozone feature (Schema version 1.1).