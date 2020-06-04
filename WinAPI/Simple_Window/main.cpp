#include "header.h"

CHAR szFileName[MAX_PATH] = {};
LPSTR lpszFileText = NULL;


int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, int nCmdShow)
{

	if (lpCmdLine[0])
	{
		//strcpy_s(szFileName, MAX_PATH, lpCmdLine);
		for (int i = 0, j = 0; lpCmdLine[i]; i++)
		{
			if (lpCmdLine[i] != '\"')szFileName[j++] = lpCmdLine[i];
		}
	}

	WNDCLASSEX wc;
	wc.cbSize = sizeof(WNDCLASSEX);
	wc.style = 0;
	wc.lpfnWndProc = WndProc;
	wc.cbClsExtra = 0;
	wc.cbWndExtra = 0;
	wc.hInstance = hInstance;
	wc.hIcon = LoadIcon(NULL, LPCSTR(IDI_ICON1));
	wc.hIconSm = LoadIcon(NULL, LPCSTR(IDI_ICON1));
	wc.hCursor = LoadCursor(NULL, IDC_ARROW);
	wc.hbrBackground = (HBRUSH)COLOR_WINDOW+2;
	wc.lpszMenuName = MAKEINTRESOURCE(IDR_MENU1);
	wc.lpszClassName = SZ_CLASS_NAME;
	if (!RegisterClassEx(&wc))
	{
		MessageBox(NULL, "Window registration faild", "Error", MB_OK | MB_ICONERROR);
		return 0;
	}

	HWND hwnd = CreateWindowEx
	(
		WS_EX_CLIENTEDGE | WS_EX_ACCEPTFILES,
		SZ_CLASS_NAME,
		"This is my first Window",
		WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT, CW_USEDEFAULT, 700, 900,
		NULL, NULL, hInstance, NULL
	);


	if (hwnd == NULL)
	{
		MessageBox(NULL, "window not created", "Error", MB_OK | MB_ICONERROR);
		return 0;
	}

	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);

	MSG msg;
	while (GetMessage(&msg, NULL, 0, 0) > 0)
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
}