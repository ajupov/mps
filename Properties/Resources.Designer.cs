﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mps.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Mps.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Ошибка.
        /// </summary>
        internal static string ErrorCaption {
            get {
                return ResourceManager.GetString("ErrorCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Приоритет с указанным значением уже существует.
        /// </summary>
        internal static string ExistPriorityValueErrorMessage {
            get {
                return ResourceManager.GetString("ExistPriorityValueErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Завершение работы.
        /// </summary>
        internal static string ExitCaption {
            get {
                return ResourceManager.GetString("ExitCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Вы действительно хотите завершить работу?.
        /// </summary>
        internal static string ExitQuestionMessage {
            get {
                return ResourceManager.GetString("ExitQuestionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Файл успешно сохранён.
        /// </summary>
        internal static string FileSavedSuccessfullyInformationMessage {
            get {
                return ResourceManager.GetString("FileSavedSuccessfullyInformationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Введено отрицательное или нулевое значение.
        /// </summary>
        internal static string NegativeOrZeroValueEnteredErrorMessage {
            get {
                return ResourceManager.GetString("NegativeOrZeroValueEnteredErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Некорректное значение ячейки.
        /// </summary>
        internal static string NotCorrectCellValueErrorMessage {
            get {
                return ResourceManager.GetString("NotCorrectCellValueErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Некорректные значения интенсивностей для рассчёта.
        /// </summary>
        internal static string NotCorrectIntensivityValuesToCalculateErrorMessage {
            get {
                return ResourceManager.GetString("NotCorrectIntensivityValuesToCalculateErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Произошла неизвестная ошибка.
        /// </summary>
        internal static string OcceredUnclownExceptionErrorMessage {
            get {
                return ResourceManager.GetString("OcceredUnclownExceptionErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Сохранение.
        /// </summary>
        internal static string SaveFileCaption {
            get {
                return ResourceManager.GetString("SaveFileCaption", resourceCulture);
            }
        }
    }
}
