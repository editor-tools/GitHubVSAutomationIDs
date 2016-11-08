The new UI test automation project will require static automation IDs for each control that will be tested. Each control in the GHfVS extension has an optional `AutomationProperties.AutomationId` attribute that will be populated with the IDs from the resx file(s) in this project.


Resource (.resx) files typically have 3 fields per row: Name, value, and comment. The name and value field will contain a descriptive name to define the control in question, and will be unique. The comment field currently
doesn't serve a purpose for this project.

# Naming Convention
 The current naming convention of the AutomationIDs are currently:

 Descriptive name + control type

The descriptive name should contain the:

- Feature set (Pull Requests, Gist, etc)
- Function (Creates, Deletes, etc)

The control type should refer to the type of control being tested. (Pane, Button, etc)
