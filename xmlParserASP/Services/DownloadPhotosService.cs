using System.Drawing.Imaging;
using System.Drawing;
using xmlParserASP.Models;

namespace xmlParserASP.Services
{
    public class DownloadPhotosService
    {
        private DownloadPhotosResultModel _resultModel;
        public DownloadPhotosService(DownloadPhotosResultModel resultModel)
        {
            _resultModel = resultModel;
        }
        public async Task <DownloadPhotosResultModel> DownloadPhotos(List<string> productImages, string? desktopSubFolder, bool resize)
        {
            if (desktopSubFolder == null)
            {
                desktopSubFolder = "Downloaded images";
            }
            try
            {
                using (var client = new HttpClient())
                {
                    foreach (var photoUrl in productImages)
                    {
                        //var originalFileName = Path.GetFileNameWithoutExtension(photoUrl);
                        //var extension = Path.GetExtension(photoUrl);
                        var fileName = Path.GetFileName(photoUrl);
                        var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                        if (!Directory.Exists(Path.Combine(desktopPath, desktopSubFolder)))
                        {
                            Directory.CreateDirectory(Path.Combine(desktopPath, desktopSubFolder));
                        }

                        var fullFilePath = Path.Combine(desktopPath, desktopSubFolder, fileName);

                        if (File.Exists(fullFilePath))
                        {
                            _resultModel.TotalPhotoPassedExists++;
                            continue;
                        }

                        using (var response = await client.GetAsync(photoUrl))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                //string? photoFilePath = Path.Combine(_suppSetting.PhotoFolder, imageName) ?? @"D:\\Downloads\img\";

                                using (var photoStream = await response.Content.ReadAsStreamAsync())
                                {
                                    using (var image = Image.FromStream(photoStream))
                                    {
                                        photoStream.Seek(0, SeekOrigin.Begin);

                                        if (resize)
                                        {
                                            if (image.Width > 1000 || image.Height > 1000)
                                            {
                                                int newWidth, newHeight;

                                                if (image.Width > image.Height)
                                                {
                                                    newWidth = 1000;
                                                    newHeight = (int)((float)image.Height / image.Width * newWidth);
                                                }
                                                else
                                                {
                                                    newHeight = 1000;
                                                    newWidth = (int)((float)image.Width / image.Height * newHeight);
                                                }

                                                using (var resizedImage = new Bitmap(image, newWidth, newHeight))
                                                {
                                                    resizedImage.Save(fullFilePath, ImageFormat.Jpeg);
                                                    _resultModel.TotalPhotosResized++;
                                                }
                                            }
                                            else
                                            {
                                                using (var fileStream = new FileStream(fullFilePath, FileMode.Create))
                                                {
                                                    photoStream.Seek(0, SeekOrigin.Begin);
                                                    await photoStream.CopyToAsync(fileStream);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            using (var fileStream = new FileStream(fullFilePath, FileMode.Create))
                                            {
                                                photoStream.Seek(0, SeekOrigin.Begin);
                                                await photoStream.CopyToAsync(fileStream);
                                            }
                                        }

                                        // Add the photo URL to the HashSet for this model
                                        _resultModel.TotalPhotosDownloaded++;
                                        _resultModel.NewPhotosAdded++;
                                    }
                                }
                            }
                            else
                            {
                                _resultModel.wrongUrl.Add(new KeyValuePair<string, string>("fromDb", photoUrl));
                                _resultModel.CannotDownload++;
                            }
                        }
                    }

                    if (_resultModel.NewPhotosAdded == 0)
                    {
                        _resultModel.ResultMessages.Add("No new photos added. All photos already exist in the destination folder.");
                    }
                    else
                    {
                        _resultModel.ResultMessages.Add($"Total photos downloaded: {_resultModel.TotalPhotosDownloaded}. Total photos resized: {_resultModel.TotalPhotosResized}. Photos passed because exists {_resultModel.TotalPhotoPassedExists}. Wrong URL, image was not downloaded: {_resultModel.CannotDownload}");
                        //ViewBag.WrongUrl = _resultModel.wrongUrl;
                    }
                }
            }
            catch (Exception ex)
            {
                _resultModel.ResultMessages.Add( "An error occurred: " + ex.Message);
            }

            return _resultModel;
        }
    }
}
