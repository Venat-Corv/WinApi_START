#pragma once
#include<Windows.h>
#include<CommCtrl.h>
#include"resource.h"
CONST CHAR SZ_CLASS_NAME[] = "MyWindowClass";

extern CHAR szFileName[MAX_PATH];
extern LPSTR lpszFileText;

extern HFONT g_hFont;
extern COLORREF g_rgbText;

BOOL LoadTextFileToEdit(HWND hEdit, LPCTSTR lpzFileName);
BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
BOOL SaveFileFromEdit(HWND hEdit, LPCTSTR lpszFileName);

LRESULT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

BOOL _stdcall DoFileOpen(HWND hwnd);
VOID DoFileSaveAs(HWND hwnd);
VOID DoSelectFont(HWND hwnd);

BOOL FileChanged(HWND hEdit);
BOOL _stdcall DoFileNew(HWND hwnd);

VOID SetFileNameToStatusBar(HWND hEdit);
VOID WathChanged(HWND hwnd, BOOL(_stdcall *Action)(HWND));