# MarginWhiteSpaceRemover
Removes the margin of whitespace of pasted text. This margin is on the left and is usually apparent when copying sections of code.

## Basics
When copying code from an IDE, the spacing on the left of the code is often undesirable. This spacing will be referred to as the "white space margin". This application gets rid of this margin so the copied code can be pasted into, say, a GitHub code block without the unnecessary indentation. Simply paste code into the upper textbox and the desired whitespace will be trimmed. The output text will show up in the lower text box. The status bar will indicate what kind of whitespace is present in the whitespace margin. Both tabs and standard spaces can be processed by the program. Unfortunately, considering tabs can vary in size, text that has a mix of these two types may have an undesirable output. To remedy this, the program can translate tabs into a specific amount of spaces before the whitespace margin is removed. This is better than the program trying to guess how large the tabs are. (This is typically not a problem since programming IDEs almost always use soft tabbing).
The program provides a mechanism which will automatically process any text copied to the clipboard. Simply check “Auto-trim Clipboard”. When this option is enabled, text in the clipboard will be processed, displayed in the output textbox, and then recopied to the clipboard. This will happen every time the clipboard text differs from the output text. One can enable this option, minimize the application to system tray, then copy and paste away.

![alt text](http://i.imgur.com/aKuIhYH.png "Main window")

## Goodies
I decided to automatically bind the Settings to the default value of controls. The settings must be named the same as the control with the exception that the first letter of the setting may be uppercase.

```C#
/// <summary>
/// Automatically binds the default properties of controls to settings. The settings property must be
/// named the same as the control it needs to bind to. The settings property name can start with a capital
/// and still match properly named controls. Ex. Settings.Default.CheckBoxFoo will bind to the
/// <see cref="CheckBox.Checked"/> property of a control named checkBoxFoo.
/// </summary>
private void BindControlsToSettings()
{
    var settingsProperties = Settings.Default.GetType().GetProperties();

    foreach (Control control in this.GetAllChildren())
    {
        string controlNameFirstCap = control.Name.CapitalizeFirstChar();
        Type controlType = control.GetType();
        var defaultProperty = controlType.GetCustomAttribute<DefaultPropertyAttribute>();

        foreach (PropertyInfo property in settingsProperties)
        {
            if (property.Name.Equals(controlNameFirstCap, StringComparison.Ordinal))
                control.DataBindings.Add(defaultProperty.Name, Settings.Default, property.Name);
        }
    }
}
```

There are some nice helper methods in this project that can be freely consumed (this project is unlicensed).

