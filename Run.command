#!/bin/sh
cd `dirname $0`
while true
do
    ./UnityAutoRestartTest.app/Contents/MacOS/UnityAutoRestartTest && exit -1
done
