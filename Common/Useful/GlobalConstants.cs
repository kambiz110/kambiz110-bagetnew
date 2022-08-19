using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Useful
{
    public static class GlobalConstants
    {
        public const string serverImageUrl = "https://localhost:44327/";
        
        public const string SystemName = "ZanjaniShop";

        public const string Administration = "Administration";

        public const string AdministratorRoleName = "Administrator";

        public const string AdminLayout = "_LayoutAdmin";

        public const string StudentLayout = "_LayoutStudent";

        public const string ManegerRoleName = "Maneger";

        public const string PostManegerRoleName = "PostManeger";
        public const string SelerManegerRoleName = "SelerManeger";
        public const string UserRoleName = "User";

        public const string AdministratorAndTeacherAuthorizationString = "Administrator, Teacher";

        public const string RotativaPath = "wwwroot/Rotativa";

        public const string ExceptionHandlerPath = "/Home/Error";

        public const string StatusCodePath = "/Home/StatusCode?code={0}";

        public const int CookieTimeOut = 1;

        public const string Empty = "empty";

        public const string DashboardRequest = "DashboardRequest";

        public const string PageToReturnTo = "Page";

        public const string SplitOption = ", ";

        public static class DataSeeding
        {
            public const string AdminPassword = "K@rd!N1399";
            public const string ManegerPassword = "Ww@1400+";

            public const string AdminName = "Admin";
            public const string ManegerName = "Maneger";
            public const string AdminEmail = "admin@admin.com";
            public const string ManegerEmail = "Maneger@Maneger.com";
            public const string CustomerName = "customer";

            public const string CustomerEmail = "customer@customer.com";

        }

        public static class ErrorMessages
        {
            public const string EmptyPasswordField = "You should enter password if you want to use this shortcut! Try again!";

            public const string QuizNotFound = "There is no quiz with password {0}! Try again!";

            public const string PermissionDenied = "You do not have a permission to participate in this quiz!";

            public const string EmptyPassword = "emptyField";

            public const string MessagesAreSend = "You successfully send quiz password to all members of the event groups!";

            public const string EmptyEmailField = "You should enter email if you want to add somebody to role.";
        }

        public static class Coockies
        {
            public const string TimeZoneIana = "timeZoneIana";
        }

        public static class EmailSender
        {
            public const string EventInvitationSubject = "Event invitation";
            public const string ConfirmEmailSubject = "Confirm your email";
            public const string SenderEmail = "ZanjaniShop@gmail.com";
            public const string SenderName = "ZanjaniShop team";
            public const string StringToReplace = "{password}";
        }
    }
}
