using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace comparitron
{
    public class ComparitronExporter
    {
        ComparitronCore comparitron = null;
        SettingsCore settings = null;

        public ComparitronExporter(ComparitronCore comparitron, SettingsCore settings)
        {
            this.settings = settings;
            this.comparitron = comparitron;
        }

        public void Run()
        {
            //Create file 
            string outfile = @"D:\comptest\page.php";

            using (var output = new StreamWriter(outfile))
            {
                //Insert upper template
                //Page elements from list
                output.WriteLine(@"<ul>");
                for (var i=0; i<comparitron.itemList.Count; ++i)
                {
                    ComparitronItem item = comparitron.itemList[i];
                    ComparitronItem nextItem = null;

                    //Find next item
                    if(i < comparitron.itemList.Count- 1)
                    {
                        nextItem = comparitron.itemList[i + 1];
                    }

                    switch (item.Type)
                    {
                        case ItemType.Comparison:
                            {
                                //If there's no caption, append to previous thing, unless this is the first thing
                                if((!string.IsNullOrEmpty(item.Text)) || (i == 0))
                                {
                                    output.WriteLine(@"<li>");
                                    output.WriteLine(item.Text);
                                }
                                
                                output.WriteLine("<div class=\"twentytwenty-container\">");
                                output.WriteLine("\t<img src=\"./images/{0}/tv-{1:D5}.jpg\" />", comparitron.ProjectID, item.Frame);
                                output.WriteLine("\t<img src=\"./images/{0}/bd-{1:D5}.jpg\" />", comparitron.ProjectID, item.Frame);
                                output.WriteLine("</div>");
                                
                                /*
                                 If this is the last entry, end the list item.
                                 If it's followed by something that isn't a comparison frame, end
                                 If it's followed by a comparison frame with a caption, end
                                */
                                if((nextItem == null) || ((nextItem.Type != ItemType.Comparison) || ((nextItem.Type == ItemType.Comparison) && (!string.IsNullOrEmpty(nextItem.Text)))))
                                {
                                    output.WriteLine(@"</li>");
                                }
                            }; break;
                        case ItemType.Text:
                            {
                                output.WriteLine(@"<li>");
                                output.WriteLine(item.Text);
                                output.WriteLine(@"</li>");
                            }; break;
                        case ItemType.Image:
                            {
                                output.WriteLine(@"<li>");
                                output.WriteLine(@"<img src='{0}' title='{1}' />", item.Image, item.Text);
                                output.WriteLine(@"</li>");
                            }; break;
                        case ItemType.Video:
                            {
                                output.WriteLine(@"<li>");
                                //Figure out later
                                output.WriteLine(@"</li>");
                            }; break;
                        case ItemType.Divider:
                            {
                                output.WriteLine(@"<hr/>");
                            }; break;
                    }
                }
                output.WriteLine(@"</ul>");

                //Insert lower template
            }
        }

    }
}
