<a href="http://github.com/goosetuv/snow-log-collector"><img src="/images/slc-logo.png" title="Snow Log Collector" alt="SRD Logo"></a>

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

**This program is currently being rewritten from the ground up.  Version 1 still works, however certain log locations that have been added in Snow updates do not exist.**

Collecting Logs is boring, don't do it manually. Free Windows Tool for pulling logs for Snow License Manager and Snow Inventory!

---

## Screenshot
<a href="http://github.com/goosetuv/snow-log-collector"><img src="/images/slc_mainscreen.png" title="Snow Log Collector" alt="Snow Log Collector Screenshot"></a>

## Installation

Download the latest release and run!

## Features

- Collect logs for all aspects of Snow License Manager (incl. physical logs on server and from database)
- Collect logs for all aspects of Snow Inventory Server (incl. physical logs on server and from database)
- Collect logs for Snow Update Service
- Collect logs for Snow Inventory Agent on local and remote machines (and on other domains!)

## Product Support

- Support for Snow License Manager 7.x, 8.x and 9.x
- Support for Snow Inventory Server 3.x, 5.x and 6.x

**Please note that the Snow License Manager 7 and Snow Inventory Server 3 support is only partial as these applications are end-of-life and end-of-support.  Although it works, no additional updates will be added for these two versions.**

I have tried to create this in such a way that it supports installations of the Snow Software Suite on other drives other than default (i.e installed on E:\ instead of C:\), however please note that non-standard drive installations are not supported out of the box, and any bugs or crashes that happen will need to be raised as an issue to investigate. 

## Usage

Download the latest release and run the installer. 

Once in the application, click on the settings tab and fill out your sql server and application server names then save. 

Then off ya go!

## References

I used the following links for most of the paths, however this document isn't completely up to date so some of them were done manually.

[How to: collect Snow License Manager logs and configurations](https://community.snowsoftware.com/s/article/HowtocollectSnowLicenseManagerlogsandconfigurations-v2)

[How to: collect Snow Inventory logs and configurations](https://community.snowsoftware.com/s/article/HowtocollectSnowInventorylogsandconfigurations-v2)

## Contributing
Happy for anyone to make a pull request to assist in making the application better.

## Legal Notice
This software is 3rd party and is no way officially endorsed or affiliated with Snow Software.  The Snow Software name and image are copyright Snow Software AB.
