﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASC.Web.CRM.Services.NotifyService {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CRMPatternResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CRMPatternResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ASC.Web.CRM.Services.NotifyService.CRMPatternResource", typeof(CRMPatternResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to h1. Добавлено событие к &quot;$EntityTitle&quot;:&quot;${__VirtualRootPath}/${EntityRelativeURL}&quot;            
        ///
        ///$__DateTime Пользователь &quot;$__AuthorName&quot;:&quot;$__AuthorUrl&quot; добавил событие к &quot;$EntityTitle&quot;:&quot;${__VirtualRootPath}/${EntityRelativeURL}&quot;.                                                                  
        ///
        ///$AdditionalData.get_item(&quot;EventContent&quot;)
        ///
        ///#foreach($fileInfo in $AdditionalData.get_item(&quot;Files&quot;).Keys)
        ///
        ///#beforeall
        ///
        ///----------------------------------------
        ///
        ///#each
        ///
        ///&quot;$fileInfo&quot;:&quot;$AdditionalData.get_it [rest of string was truncated]&quot;;.
        /// </summary>
        public static string pattern_AddRelationshipEvent {
            get {
                return ResourceManager.GetString("pattern_AddRelationshipEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to h1. CRM. Создан &quot;$EntityTitle&quot;:&quot;${__VirtualRootPath}/products/crm/default.aspx?ID=$EntityID&quot; через &apos;Web-to-Contact Form&apos;
        ///    
        ///Адрес Вашего портала: &quot;$__VirtualRootPath&quot;:&quot;$__VirtualRootPath&quot;
        ///
        ///Информация о контакте:
        ///
        ///#foreach($contactInfo in $AdditionalData.Keys)
        ///#each
        ///
        ///$contactInfo: $AdditionalData.get_item($contactInfo)
        ///
        ///#end
        ///
        ///          
        ///Адрес Вашего портала: &quot;$__VirtualRootPath&quot;:&quot;$__VirtualRootPath&quot;
        ///          
        ///&quot;Изменение параметров подписки&quot;:&quot;$RecipientSubscriptionConfigURL&quot;.
        /// </summary>
        public static string pattern_CreateNewContact {
            get {
                return ResourceManager.GetString("pattern_CreateNewContact", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to h1. CRM. Экспорт данных был успешно завершен   
        ///    
        ///Адрес Вашего портала: &quot;$__VirtualRootPath&quot;:&quot;$__VirtualRootPath&quot;
        ///          
        ///Ссылка для скачивания архива: &quot;exportdata.zip&quot;:&quot;${EntityRelativeURL}&quot;
        ///         
        ///Внимание! Ссылка активна в течение одного дня.
        ///          
        ///Адрес Вашего портала: &quot;$__VirtualRootPath&quot;:&quot;$__VirtualRootPath&quot;
        ///          
        ///&quot;Изменение параметров подписки&quot;:&quot;$RecipientSubscriptionConfigURL&quot;.
        /// </summary>
        public static string pattern_ExportCompleted {
            get {
                return ResourceManager.GetString("pattern_ExportCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to h1.Вас назначили ответственным за задачу: &quot;$EntityTitle&quot;:&quot;${__VirtualRootPath}/products/crm/tasks.aspx?ID=$EntityID&quot;
        ///
        ///$__DateTime Пользователь &quot;$__AuthorName&quot;:&quot;$__AuthorUrl&quot; назначил вас ответственным за задачу: &quot;$EntityTitle&quot;:&quot;${__VirtualRootPath}/products/crm/tasks.aspx?ID=$EntityID&quot; .
        ///
        ///$AdditionalData.get_item(&quot;TaskDescription&quot;)
        ///
        ///#foreach($fileInfo in $AdditionalData.get_item(&quot;Files&quot;).Keys)
        ///
        ///#beforeall
        ///
        ///----------------------------------------
        ///
        ///#each
        ///
        ///&quot;$fileInfo&quot;:&quot;$AdditionalData.get_item(&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string pattern_ResponsibleForTask {
            get {
                return ResourceManager.GetString("pattern_ResponsibleForTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to h1.Вам предоставили доступ к &quot;$EntityTitle&quot;:&quot;${__VirtualRootPath}/${EntityRelativeURL}&quot;
        ///
        ///$__DateTime Пользователь &quot;$__AuthorName&quot;:&quot;$__AuthorUrl&quot; предоставил Вам доступ к &quot;$EntityTitle&quot;:&quot;${__VirtualRootPath}/${EntityRelativeURL}&quot;.
        ///
        ///Адрес Вашего портала: &quot;$__VirtualRootPath&quot;:&quot;$__VirtualRootPath&quot;
        ///
        ///&quot;Изменение параметров подписки&quot;:&quot;$RecipientSubscriptionConfigURL&quot;.
        /// </summary>
        public static string pattern_SetAccess {
            get {
                return ResourceManager.GetString("pattern_SetAccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CRM. Добавлено событие к $EntityTitle.
        /// </summary>
        public static string subject_AddRelationshipEvent {
            get {
                return ResourceManager.GetString("subject_AddRelationshipEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CRM.  Создан новый контакт через &apos;Web-to-Contact Form&apos;.
        /// </summary>
        public static string subject_CreateNewContact {
            get {
                return ResourceManager.GetString("subject_CreateNewContact", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CRM. Экспорт данных был успешно завершен.
        /// </summary>
        public static string subject_ExportCompleted {
            get {
                return ResourceManager.GetString("subject_ExportCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CRM. Вас назначили ответственным за задачу: $EntityTitle.
        /// </summary>
        public static string subject_ResponsibleForTask {
            get {
                return ResourceManager.GetString("subject_ResponsibleForTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CRM. Вам предоставили доступ к $EntityTitle.
        /// </summary>
        public static string subject_SetAccess {
            get {
                return ResourceManager.GetString("subject_SetAccess", resourceCulture);
            }
        }
    }
}
