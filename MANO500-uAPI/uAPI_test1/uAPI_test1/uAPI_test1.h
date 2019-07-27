// uAPI_test1.h : main header file for the PROJECT_NAME application
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// CuAPI_test1App:
// See uAPI_test1.cpp for the implementation of this class
//

class CuAPI_test1App : public CWinApp
{
public:
	CuAPI_test1App();

// Overrides
	public:
	virtual BOOL InitInstance();

// Implementation

	DECLARE_MESSAGE_MAP()
};

extern CuAPI_test1App theApp;