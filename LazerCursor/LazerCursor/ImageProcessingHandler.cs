using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing;
using System.Drawing;

namespace LazerCursor
{
    public class ImageProcessingHandler
    {
        private Queue<Task<ImageProcessingResult>> TaskQueue { get; set; }
        private Settings SelectedSettings { get; set; }
        public delegate void ImageHandledCallback(ImageProcessingResult result);
        private ImageHandledCallback CallBack { get; set; }

        public ImageProcessingHandler(Settings settings, ImageHandledCallback callBack)
        {
            SelectedSettings = settings;
            CallBack = callBack;
            TaskQueue = new Queue<Task<ImageProcessingResult>>();
            Task.Factory.StartNew(this.RunTaskChecker);
        }

        public void HandleNewImage(Bitmap image)
        {
            var taskHandler = Task.Factory.StartNew<ImageProcessingResult>(() =>
                {
                    LazerManager lazerManager = new LazerManager(SelectedSettings);
                    var cursorChange = lazerManager.CalculateChangeLockedBits(image);

                    return new ImageProcessingResult(image, cursorChange);
                });
            TaskQueue.Enqueue(taskHandler);
        }

        public void RunTaskChecker()
        {
            while (true)
            {
                if (TaskQueue.Count > 0)
                {
                    TaskQueue.Peek().Wait();
                }
                if (TaskQueue.Count > 0 && TaskQueue.Peek().IsCompleted)
                {
                    CallBack(TaskQueue.Dequeue().Result);
                }
            }
        }
    }

    public class ImageProcessingResult
    {
        public Bitmap Image { get; set; }
        public CursorChange CursorResult { get; set; }
        public ImageProcessingResult(Bitmap image, CursorChange result)
        {
            Image = image;
            CursorResult = result;
        }
    }
}
