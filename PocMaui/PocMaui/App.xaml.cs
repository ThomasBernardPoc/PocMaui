﻿using PocMaui.Views;

namespace PocMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ColorPickerPage();
	}
}
