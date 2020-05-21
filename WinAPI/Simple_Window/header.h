#pragma once
#include<Windows.h>
#include<CommCtrl.h>
#include"resource.h"
CONST CHAR SZ_CLASS_NAME[] = "MyWindowClass";

extern CHAR szFileName[MAX_PATH];
extern LPSTR lpszFileText;

BOOL LoadTextFileToEdit(HWND hEdit, LPCTSTR lpzFileName);
BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
BOOL SaveFileFromEdit(HWND hEdit, LPCTSTR lpszFileName);

LRESULT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

VOID DoFileOpen(HWND hwnd);
VOID DoFileSaveAs(HWND hwnd);

BOOL FileChanged(HWND hEdit);