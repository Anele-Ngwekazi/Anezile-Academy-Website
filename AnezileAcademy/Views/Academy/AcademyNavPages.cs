﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace AnezileAcademy.Views.Academy
{
    public static class AcademyNavPages
    {
        public static string ActivePageKey => "ActivePage";

        public static string Index => "Index";

        public static string Exercises => "Exercises";

        public static string Assignments => "Assignments";

        public static string Tests => "tests";

        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);

        public static string ExercisesNavClass(ViewContext viewContext) => PageNavClass(viewContext, Exercises);

        public static string AssignmentsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Assignments);

        public static string TestsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Tests);
    
        public static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string;
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }

        public static void AddActivePage(this ViewDataDictionary viewData, string activePage) => viewData[ActivePageKey] = activePage;
    }
}
