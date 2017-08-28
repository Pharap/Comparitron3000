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
        Settings settings = null;
        public bool Running { get; private set; } = false;
        public string log { get; private set; } = "";

        public ComparitronExporter(ComparitronCore comparitron, Settings settings)
        {
            this.settings = settings;
            this.comparitron = comparitron;
        }

        public void Run()
        {
            log = "";
            Running = true;

            //Create directory and file 
            string basePath = comparitron.BasePath;
            string outPath = comparitron.BasePath + @"/output/";
            string outFile = outPath + comparitron.ProjectID + ".php";

            if(!Directory.Exists(outPath))
            {
                Directory.CreateDirectory(outPath);
            }

            //Start writing to it
            using (var output = new StreamWriter(outFile))
            {
                log += "Starting write..." + "\r\n";
                //Insert upper template

                    //quick bodge to get things working
                    output.WriteLine(@"<html><head>");
                    output.WriteLine(@"<link href='css/twentytwenty.css' rel='stylesheet' type='text/css'/>");
                    output.WriteLine(@"</head><body>");

                //Page elements from list
                output.WriteLine(@"<ul>");

                log += "Items : " + comparitron.itemList.Count + "\r\n";
                for (var i=0; i<comparitron.itemList.Count; ++i)
                {
                    ComparitronItem item = comparitron.itemList[i];
                    ComparitronItem nextItem = null;

                    log += i.ToString() + " : " + item.Type.ToString() + "\r\n";

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
                                if((nextItem == null) || (nextItem.Type != ItemType.Comparison) || ((nextItem.Type == ItemType.Comparison) && (!string.IsNullOrEmpty(nextItem.Text))))
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

                                output.Write(@"<video width='auto' {0}>", item.Text);
                                output.Write(@"<source src='{0}' type='video/mp4'>",item.Video);
                                //Fallback image
                                if (!string.IsNullOrEmpty(item.Image))
                                    output.Write(@"<img src='{0}' style='max-width: 100%'>", item.Image);
                                output.Write(@"</video>");

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

                //Quick bodge to get things working
                    output.WriteLine(@"<script src='https://ajax.googleapis.com/ajax/libs/jquery/1.10.1/jquery.min.js'></script>");
                    output.WriteLine(@"<script src='js/jquery.event.move.js'></script>");

                    output.WriteLine(@"<script src='js/jquery.twentytwenty.js'></script>");
                    output.WriteLine(@"</body></html>");

                log += "Done! \r\n";
            }

            //Move image files
            if (Directory.Exists(basePath+@"\old\") && (Directory.Exists(basePath+@"\new\")))
            {
                string imagePath = basePath + @"\output\images\" + comparitron.ProjectID + @"\";
                log += "Moving image files..." + "\r\n";

                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);

                foreach (var line in comparitron.itemList)
                {
                    if (line.Type == ItemType.Comparison)
                    { 
                        string tvName = string.Format("tv-{0:D5}.jpg", line.Frame);
                        string bdName = string.Format("bd-{0:D5}.jpg", line.Frame);

                        log += "Moving " + tvName + " from " + basePath + @"\old to " + imagePath + "\r\n";
                        if (File.Exists(basePath + @"\old\" + tvName))
                        { 
                            File.Copy(basePath + @"\old\" + tvName, imagePath + tvName, true);
                        }
                        log += "Moving " + bdName + " from " + basePath + @"\new to " + imagePath + "\r\n";
                        if (File.Exists(basePath + @"\new\" + bdName))
                        {
                            File.Copy(basePath + @"\new\" + bdName, imagePath + bdName, true);
                        }
                    }
                }
                log += "Done! \r\n";
            }

            log += "Export complete, go home \r\n";

            Running = false;
        }

    }
}
