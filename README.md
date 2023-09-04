# UnityAutoRestartTest

Sometimes, I build a "kiosk mode" app with Unity for digital signages or museum installations. It should meet the following requirements.

- It should periodically terminate the process to release memory/resources.
- It should automatically restart the process on terminations/crashes.
- It shouldn't restart the process when an operator manually stops it.

This repository contains a simple Unity project and a shell script fulfilling them.
