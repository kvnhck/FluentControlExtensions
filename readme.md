FluentControlExtensions for ASP.NET WebForms
============================================

What this is for
----------------

This library of web control extensions provides a fluent interface to create and manipulate ASP.NET Web Controls.

Examples
--------

Creating controls:

	var textbox = ControlFactory.Create<TextBox>();
	
	var label = ControlFactory.Create<Label>("lblName");

	var ddl = ControlFactory.Create<DropDownList>()
        .DataBind(new List<string>() { "Item 1", "Item 2" });

Manipulating controls:

	textbox
		.ID("txtName")
		.EnableViewState(false)
		.Text("Your name")
		.Enabled(false)
		.ToolTip("Enter your name here");

	label
		.AssociateWith(textbox)
		.Visible(true)
		.SkinID("default")
		.AddCssClass("name")
		.AddStyle("color", "red");

ControlCollections:

	Page.Controls.Create<TextBox>("txtName").Text("Your name");

	Page.Controls.ForEach<TextBox>(t => t.CssClass("text"));
