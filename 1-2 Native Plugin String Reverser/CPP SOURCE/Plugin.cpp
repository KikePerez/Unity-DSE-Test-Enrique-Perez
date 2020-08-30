
#if _MSC_VER // this is defined when compiling with Visual Studio
#define EXPORT_API __declspec(dllexport) // Visual Studio needs annotating exported functions with this
#else
#define EXPORT_API // XCode does not need annotating exported functions, so define is empty
#endif

extern "C"
{

EXPORT_API void ReverseText(const char *input, char *output, int len)
{
	for (int i = 0; i<sizeof(input) / 2; i++)
	{
		char temp = input[i];
		output[i] = input[len - i - 1];
		output[len - i - 1] = temp;
	}
}

} // end of export C block
