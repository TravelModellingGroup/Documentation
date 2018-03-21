What's new in XTMF Version 1.4?
##############################################################################

Details
------------------------------------------------------------------------------------

Bug Fixes
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
As always, new iterations of XTMF address bugs previously identified in any of the issues created on the Github project tracker, and others
we may find internally.


Updated GUI
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
XTMF 1.4 now uses a more modern layout. Although 1.3 introduced a new look and feel, 1.4 further improves on that by using 
material design by Google which is more familiar to a much larger percentage of users. Earlier versions of XTMF included a 
standard File menu for application actions. This has been removed and replaced with a "global" window menu which attempts to behave
more similarly to native Windows applications. The menu has been placed in a sidebar which can be called from any section or tab of
the XTMF.Gui application.

Themeing has also been substantially improved. Palette and light/dark settings are provided by the Material theme and XTMF no longer uses
the previous colour palettes (forest green, etc).

Unified Runs Under the Scheduler Window
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
Model system runs will now appear under the same window: the Scheduler window. The scheduler window introduces two run lists "active" and "finished",
which provides a useful overview of all past, present (and future) runs that have been initiated by the XTMF client. 

Run Queueing
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
Model system runs can now be queued. XTMF 1.4 introduces the ability to both schedule and queue model system runs. A user can choose to have runs
execute simultaneously. This feature allows the user to postpone the starting of a model system run to a later date in time when there will be more
computing resources available, without having to actively be present at their workstation.

System and In-App Notifications
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
Several quality-of-life notifications systems has been added to XTMF. No matter which tab or window you are interacting with in XTMF, finished model system runs
will now display an in-app toast to notify if you have any errors (or success) messages that have occurred during an executing model system. In addition
to in-app toast messages, notification messages are also sent to the System tray, and will be collated by Windows for review for a later time if the user is 
not currently at the workstation.


Requesting New Features
------------------------------------------------------------------------------------
New feature requests are always welcome for the XTMF project. If you would like to contribute, make any suggestions for a new feature, or report any
bugs encountered during your usage of XTMF please see: https://github.com/TravelModellingGroup/XTMF/issues.