The new UI test automation project will require static automation IDs for each control that will be tested. Each control in the GHfVS extension has an optional `AutomationProperties.AutomationId` attribute that will be populated with the IDs from the resx file(s) in this project.


Resource (.resx) files typically have 3 fields per row: Name, value, and comment. The name field will contain a descriptive name to define the control in question, the value field will contain a GUID, which will be the `AutomationID` of the control.

# Naming Convention
 TBD


