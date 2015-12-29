# Caliburn.Micro.TestingHelpers

The caliburn micro testing helpers are an extension to provide additional functionality for testing an `WPF`app with `Caliburn.Micro`. 


# Installation

Install the package with the nuget package manager

    install-package Caliburn.Micro.TestingHelpers


# TestWithPlatformProvider

    // this uses NEdifis creation context
	var ctx = new ContextFor<DefaultSearchViewModel>();

	var sut = ctx.BuildSut();

	var closeCalled = false;
	sut.TestWithPlatformProvider(
		platformProvider => platformProvider.CloseActionFor = (vm, views, result) => closeCalled = true,
		x => x.DoOpenSelected());


# Planned

The following features are prototyped and will be implemented soon.

* Screenshot helper - Creates screenshots based on a caliburn View/ViewModel