[![Build status](https://ci.appveyor.com/api/projects/status/o3gkdu3e4tfbaivw?svg=true)](https://ci.appveyor.com/project/awesome-inc-build/Caliburn.Micro.TestingHelpers)
[![NuGet](https://img.shields.io/nuget/v/Caliburn.Micro.TestingHelpers.svg?style=flat-square)](https://www.nuget.org/packages/Caliburn.Micro.TestingHelpers/) 
[![Nuget](https://img.shields.io/nuget/vpre/Caliburn.Micro.TestingHelpers.svg)](https://www.nuget.org/packages/Caliburn.Micro.TestingHelpers/)
[![NuGet](https://img.shields.io/nuget/dt/Caliburn.Micro.TestingHelpers.svg?style=flat-square)](https://www.nuget.org/packages/Caliburn.Micro.TestingHelpers/) 
[![Issue Stats](http://issuestats.com/github/awesome-inc/Caliburn.Micro.TestingHelpers/badge/pr)](http://issuestats.com/github/awesome-inc/Caliburn.Micro.TestingHelpers)
[![Coverage Status](https://coveralls.io/repos/awesome-inc/Caliburn.Micro.TestingHelpers/badge.svg?branch=develop&service=github)](https://coveralls.io/github/awesome-inc/Caliburn.Micro.TestingHelpers?branch=develop)



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