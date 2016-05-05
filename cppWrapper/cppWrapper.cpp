// This is the main DLL file.

#include "stdafx.h"
#include "cppWrapper.h"
#include "cppProject.h"

using namespace std;

//Constructor of wrapper.
cppWrapper::cppWrapperClass::cppWrapperClass()
{
	nativecppClass = new cppClass();
}

cppWrapper::cppWrapperClass::~cppWrapperClass()
{
	nativecppClass = NULL;
}

double cppWrapper::cppWrapperClass::cppWrapperAddMethod(double param1, double param2)
{
	return nativecppClass->cppClassAddMethod(param1, param2);
	return 0;
}