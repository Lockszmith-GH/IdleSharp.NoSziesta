IdleSharp’s NoSziesta
=====================
Keep hardrive from sleeping.

A little application that just keeps your hard drive awake by performing operations on a predefined schedule.

History - or Why I wrote this application?
------------------------------------------

I use 2 external drives on my main Desktop, these also act as my main home repository for photos, media and documents.

I found it is easier to manage external storage, since it’s easy to hook off when needed.

BUT - External HDD have a tendency to go to sleep after a few minutes of inactivity.
So I was looking for an application that would keep the drives awake.

I found one ([NoSleepHD], but I wanted it to work a bit differently.

And because of these limitations I wrote this little application.

Features
--------

-   Auto detection of USB drives and mount points, either on demand or on startup.
-   Auto save of last application state to be used on next startup.
-   Either constant intervals or random intervals between writes.
-   Custom location (for use of remotely mounted drives, or undetected ones)
-   Minimize/Hide into System Notification area (system-tray)
-   Optionally run in (semi[1]) portable-mode

------------------------------------------------------------------------

License
-------

The MIT License (MIT)

Copyright © 2013 Lockszmith aka Gal Szkolnik (code@lockszmith.com)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the “Software”), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

[1] Portable usually means without impacting the running system, in this case the temporary files written on the destination (keep awake) drives, will remain. Thus the app can only be ‘semi’ portable.

  [NoSleepHD]: http://nosleephd.codeplex.com/)
