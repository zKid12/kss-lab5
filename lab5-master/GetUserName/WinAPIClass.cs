﻿using System.Runtime.InteropServices;
using System.Text;

namespace GetUserName {
    class WinAPIClass {
        /// <summary>
        /// Получение имени текущего пользователя.
        /// </summary>
        /// <param name="nameFormat">Формат имени из перечисления NameFormat.</param>
        /// <param name="userName">Выходной параметр — имя.пользователя</param>
        /// <param name="userNameSize">Количество символов в имени.</param>
        /// <returns></returns>
        //Подключение библиотеки secur32.dll
        [DllImport("secur32.dll", CharSet = CharSet.Auto)]
        public static extern int GetUserNameEx(int nameFormat, StringBuilder userName, ref uint userNameSize);

        /// <summary>
        /// Формат имени.
        /// </summary>
        public enum NameFormat : int {
            NameUnknown = 0,
            NameFullyQualifiedDN = 1,
            NameSamCompatible = 2,
            NameDisplay = 3,
            NameUniqueId = 6,
            NameCanonical = 7,
            NameUserPrincipal = 8,
            NameCanonicalEx = 9,
            NameServicePrincipal = 10,
            NameDnsDomain = 12
        };
    }
}
