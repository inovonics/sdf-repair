sdf-repair
==========

Making a usable tool out of Microsoft's help article.

This tool requires the SQLCompact 3.5 driver to be installed.  If TapWatch3 is installed, all dependencies are already
installed.

The repair process takes about 3 minutes per 100 MB on a decently performing machine.

Directions:
- Make a backup copy of the SDF that is to be repaired.
- Open the program.
- Select the file to attempt to repair.
- Select the Repair button.
- The application may say "(not responding)".  This is normal during the repair process.  This is quick and dirty, and
I don't have the time to push the repair process to a worker thread right now.
- If a green bar appears below the file box, the repair was not needed or successful.
- If a red bar appears, the repair failed.
