<a href="http://github.com/goosetuv/snow-log-collector"><img src="/Resources/snow_log_collector1.png" title="Snow Log Collector" alt="Snow Log Collector Logo"></a>

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

Collecting Logs is boring.  Don't do it manually, let something do it for you.  Snow Log Collector allows you to pull logs for Snow License Manager and Snow Inventory in mass within seconds as well as database exports for the Data Update Job, Microsoft 365 and more.

---

## Screenshot
![SLC_LicenseManagerConfiguration](https://user-images.githubusercontent.com/14845036/160253889-ae3160d3-38d6-4214-85b7-07d550b5b5b2.png)

## Installation
Unlike Version 1.X I decided to offer a portable version of Version 2.0 as well as an install version.  For the portable version just download the .zip and run the executable and configure for your environment. 

For the installer version just download the .zip and run the .msi installer, run the executable in Program Files and configure for your environment.

### System Requirements
- Windows 10 or higher
- .NET Framework 4.7.2
- Snow License Manager 9 (see [Product Support](#product-support))
- Snow Inventory Server 6 (see [Product Support](#product-support))

### Updating from v1.x
I re-wrote Snow Log Collector entirely from the ground up.  Although it looks the same the code behind it is entirely different and using a different type of installer package, as a result installing v2.0 is seen by Windows as a brand new application. 

To update from v1.x I recommend uninstalling your current installation and then installing v2.0.  No configuration data is from v1 is supported in v2 and will need to be set up again.

## Features

- Collect logs for Snow License Manager and Snow License Manager Services
- Collect logs for Snow Inventory Server, Server Manager and Administration Console
- Collect logs for Snow Integration Manager & Snow Update Service

## Exported Data
All data from Snow Log Collector 2.0 is stored in `%AppData%\Goosetuv\Snow Log Collector\`.

- **\Resources**: This contains the scripts used for database exports
- **\Logs**: Application logs for Snow Log Collector
- **\Data\CollectedLogs**: Application logs collected for Snow License Manager, etc.
- **\Data\Exports**: Database exports for Data Update Job, Microsoft 365 etc.

## Product Support
In theory the flat file log collection should support all versions of Snow License Manager and Snow Inventory Server, but the only officially supported versions are Snow License Manager 8 & 9 and Snow Inventory Server 5 & 6. 

For database exports such as Data Update Job, Microsoft 365 and Adobe Creative Cloud are only officially supported for Snow License Manager 9.19 and above, and Snow Inventory Server 6.7.0 and above.  This is purely because of how many changes in database structure there are in the various versions, however if you are on an older version feel free to customize the `.xml` files in `%AppData%\Goosetuv\Snow Log Collector\Resources\`.

## Contributing
Happy for anyone to make a pull request to assist in making the application better.

## Legal Notice
This software is 3rd party and is no way officially endorsed or affiliated with Snow Software.
