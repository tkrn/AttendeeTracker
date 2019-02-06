# AttendeeTracker

A utility to import an attendee list, checkin attendees and printer name lables 

#### Usage

1. Import an attendee list by using the "Import Attendee List" with the minimum required fields (case-sensitive):
   * Attendeed
   * FirstName
   * LastName
   * Company
1. Select the printer and label under "Printer Settings". These fields will attempt to default to any DYMO printer and the 30857 Badge Label.
1. Check in your attendees by using "Check-in Attendee" or "Walk-on Attendee"
1. Export your checked in attendee list. 

    [![AttendeeTracker Screenshot](http://nthnk.com/github/AttendeeTracker_1_thumb.png)](http://nthnk.com/github/AttendeeTracker_1.png)


#### Download

Please download a Windows .NET 4.0 compiled binary at https://github.com/tkrn/AttendeeTracker/releases/latest 


#### Advanced Usage

* **HiddenColumns.ini** - Based on your data input, they maybe additional data that you want to retain but not modify. To remove columns from the main view of the application, insert the column name, one per line, case-sensitive in this file in the same directory as the executable.

  ![AttendeeTracker Screenshot](http://nthnk.com/github/AttendeeTracker_HiddenColumns.png)

* **logo.png** - The default logo on the name tag label can be overridden if logo.png is present in the same directory as the executable. PNG format is required with suggested dimensions of 315px * 315px at 300 DPI. 
