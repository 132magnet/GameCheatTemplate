using System;
using System.Runtime.InteropServices;

namespace GameCheatTemplate
{
    public static class MemoryUtils
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr hObject);

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public static IntPtr ResolvePointerChain(IntPtr processHandle, IntPtr baseAddress, int[] offsets)
        {
            IntPtr address = baseAddress;
            byte[] buffer = new byte[8]; // Assuming 64-bit pointers
            foreach (var offset in offsets)
            {
                if (!ReadProcessMemory(processHandle, address, buffer, buffer.Length, out _))
                    return IntPtr.Zero;

                address = IntPtr.Add((IntPtr)BitConverter.ToInt64(buffer, 0), offset);
            }
            return address;
        }

        public static float ReadFloat(IntPtr processHandle, IntPtr address)
        {
            byte[] buffer = new byte[4]; // Float is 4 bytes
            if (ReadProcessMemory(processHandle, address, buffer, buffer.Length, out _))
            {
                return BitConverter.ToSingle(buffer, 0);
            }
            return 0f; // Default value if read fails
        }

        public static void WriteFloat(IntPtr processHandle, IntPtr address, float value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            WriteProcessMemory(processHandle, address, buffer, buffer.Length, out _);
        }

        public static void WriteBytes(IntPtr processHandle, IntPtr moduleBase, int offset, byte[] bytes)
        {
            IntPtr address = moduleBase + offset;
            WriteProcessMemory(processHandle, address, bytes, bytes.Length, out _);
        }
    }
}