using System.Linq;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using TrPo.Models;

namespace TrPo
{
    public class YouTubeBroadcastService
    {
        public static async Task<Translation> BroadcastInformation(string Code)
        {
            Translation broadcast = new Translation()
            {
                Code = Code,
                Name = "",
                Condition = ""
            };
            using var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyCFBWKVDxr97N2kVKYI_oLn80SrnmACKw4",
            });
            var searchRequest = youtubeService.Videos.List("snippet");
            searchRequest.Id = Code;

            var searchResponse = await searchRequest.ExecuteAsync();
            var youTubeVideo = searchResponse.Items.FirstOrDefault();
            if (youTubeVideo != null)
            {
                broadcast.Name = youTubeVideo.Snippet.Title;
                broadcast.Condition = youTubeVideo.Snippet.LiveBroadcastContent;
            }

            return broadcast;
        }
    }
}
