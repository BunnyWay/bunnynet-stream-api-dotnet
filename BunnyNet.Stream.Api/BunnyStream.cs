using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BunnyNet.Stream.Api
{
    public class BunnyStream
    {
        private HttpClient _client = new HttpClient();

        private string _accessKey = "";
        public long VideoLibraryId { get; private set; }

        /// <summary>
        /// Create a new BunnyStream client
        /// </summary>
        public BunnyStream(string accessKey, long videoLibraryId)
        {
            _accessKey = accessKey;
            VideoLibraryId = videoLibraryId;

            _client = new HttpClient();
            _client.BaseAddress = new Uri($"https://video.bunnycdn.com/library/{videoLibraryId}/");
            _client.DefaultRequestHeaders.Add("AccessKey", accessKey);
        }

        /// <summary>
        /// Get the video 
        /// </summary>
        /// <returns></returns>
        public async Task<VideoModel> GetVideoAsync(string videoId)
        {
            using (var response = await _client.GetAsync(videoId))
            {
                if(!response.IsSuccessStatusCode)
                {
                    throw new Exception("");
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var responseModel = JsonConvert.DeserializeObject<VideoModel>(responseData);

                return responseModel;
            }
        }


        /// <summary>
        /// Delete the video with the given ID
        /// </summary>
        /// <param name="videoId">The ID of the video that will be deleted</param>
        /// <returns>The status success model returned from the API</returns>
        public async Task<StatusModel> DeleteVideoAsync(string videoId)
        {
            using (var response = await _client.DeleteAsync(videoId))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("");
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var responseModel = JsonConvert.DeserializeObject<StatusModel>(responseData);

                return responseModel;
            }
        }


        /// <summary>
        /// Get the videos 
        /// </summary>
        /// <returns></returns>
        public async Task<PaginationList<VideoModel>> GetVideos(int page, int perPage = 100)
        {

        }
    }
}
