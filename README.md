This project keeps track of automation IDs in the GitHub for Visual Studio extension. Each control in the extension has an optional `AutomationProperties.AutomationId` attribute that will be populated with the IDs from the resx file(s) in this project.


Resource (.resx) files typically have 3 fields per row: Name, value, and comment. The name and value field will contain a descriptive name to define the control in question, and will be unique. The comment field currently
doesn't serve a purpose for this project.

# Naming Convention
 The current naming convention of the AutomationIDs are currently:

 Descriptive name + control type

The descriptive name should contain the:

- Name property of the control
- HelpText property of control (if Name is not descriptive enough)

If either of those properties are not accessible (empty), or not clear enough then use:
- Feature set (Pull Requests, Gist, etc)
- Function (Creates, Deletes, etc)

The control type should refer to the type of control being tested. (Pane, Button, Custom etc)

# Copyright

Copyright 2017 GitHub, Inc.

Licensed under the [MIT License]()
