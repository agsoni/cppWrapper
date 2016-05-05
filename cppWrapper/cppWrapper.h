#pragma once

#include "cppProject.h";

using namespace std;

namespace cppWrapper {

	public ref class cppWrapperClass
	{
	public:
		cppWrapperClass();
		~cppWrapperClass();
		double cppWrapperAddMethod(double param1, double param2);

	private:
		cppClass *nativecppClass;
	};
}
