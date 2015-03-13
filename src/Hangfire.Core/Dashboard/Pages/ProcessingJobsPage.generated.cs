﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
    using Hangfire.Common;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class ProcessingJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");






            
            #line 6 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
  
    Layout = new LayoutPage("Processing Jobs");

    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    var monitor = Storage.GetMonitoringApi();
    var pager = new Pager(from, perPage, monitor.ProcessingCount());
    var processingJobs = monitor.ProcessingJobs(pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 21 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
   Write(Html.JobsSidebar());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"page-header\">Process" +
"ing Jobs</h1>\r\n\r\n");


            
            #line 26 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
         if (pager.TotalPageCount == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                No jobs are being pro" +
"cessed right now.\r\n            </div>\r\n");


            
            #line 31 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n                    <button class=\"js-jobs-list-command btn bt" +
"n-sm btn-primary\"\r\n                            data-url=\"");


            
            #line 37 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                 Write(Url.To("/jobs/processing/requeue"));

            
            #line default
            #line hidden
WriteLiteral(@"""
                            data-loading-text=""Enqueueing..."">
                        <span class=""glyphicon glyphicon-repeat""></span>
                        Requeue jobs
                    </button>

                    <button class=""js-jobs-list-command btn btn-sm btn-default""
                            data-url=""");


            
            #line 44 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                 Write(Url.To("/jobs/processing/delete"));

            
            #line default
            #line hidden
WriteLiteral(@"""
                            data-loading-text=""Deleting...""
                            data-confirm=""Do you really want to DELETE ALL selected jobs?"">
                        <span class=""glyphicon glyphicon-remove""></span>
                        Delete selected
                    </button>

                    ");


            
            #line 51 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
               Write(Html.PerPageSelector(pager));

            
            #line default
            #line hidden
WriteLiteral(@"
                </div>

                <table class=""table"">
                    <thead>
                    <tr>
                        <th class=""min-width"">
                            <input type=""checkbox"" class=""js-jobs-list-select-all""/>
                        </th>
                        <th class=""min-width"">Id</th>
                        <th class=""min-width"">Server</th>
                        <th>Job</th>
                        <th class=""align-right"">Started</th>
                    </tr>
                    </thead>
                    <tbody>
");


            
            #line 67 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                     foreach (var job in processingJobs)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr class=\"js-jobs-list-row ");


            
            #line 69 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                                Write(!job.Value.InProcessingState ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 69 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                                                                                         Write(job.Value.InProcessingState ? "hover" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <td>\r\n");


            
            #line 71 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                 if (job.Value.InProcessingState)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <input type=\"checkbox\" class=\"js-jobs-list-ch" +
"eckbox\" name=\"jobs[]\" value=\"");


            
            #line 73 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                                                                                         Write(job.Key);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n");


            
            #line 74 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n                            <td class=\"min-wid" +
"th\">\r\n                                <a href=\"");


            
            #line 77 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                    Write(Url.JobDetails(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                    ");


            
            #line 78 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                               Write(Html.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </a>\r\n");


            
            #line 80 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                 if (!job.Value.InProcessingState)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <span title=\"Job\'s state has been changed whi" +
"le fetching data.\" class=\"glyphicon glyphicon-question-sign\"></span>\r\n");


            
            #line 83 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n                            <td class=\"min-wid" +
"th\">\r\n                                ");


            
            #line 86 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                           Write(job.Value.ServerId.ToUpperInvariant());

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n          " +
"                      <a class=\"job-method\" href=\"");


            
            #line 89 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                                       Write(Url.JobDetails(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                    ");


            
            #line 90 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                               Write(Html.DisplayJob(job.Value.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </a>\r\n                            </td>\r\n      " +
"                      <td class=\"align-right\">\r\n");


            
            #line 94 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                 if (job.Value.StartedAt.HasValue)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <span data-moment=\"");


            
            #line 96 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                                  Write(JobHelper.ToTimestamp(job.Value.StartedAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                            ");


            
            #line 97 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                       Write(job.Value.StartedAt);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </span>\r\n");


            
            #line 99 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n                        </tr>\r\n");


            
            #line 102 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");


            
            #line 106 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
            
            
            #line default
            #line hidden
            
            #line 106 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
       Write(Html.Paginator(pager));

            
            #line default
            #line hidden
            
            #line 106 "..\..\Dashboard\Pages\ProcessingJobsPage.cshtml"
                                  
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
