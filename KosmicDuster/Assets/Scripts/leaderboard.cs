using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;
using UnityEngine.SocialPlatforms.Impl;
using System.Security.Cryptography.X509Certificates;

public class leaderboard : MonoBehaviour
{
    [SerializeField]
    private List<TextMeshProUGUI> names;
    [SerializeField]
    private List<TextMeshProUGUI> scores;

    private string publicLeaderboardKey = 
        "4dd15e4e9920efa2bf42bb879febbd77a99c1a82e34c456c4c8c603ce5a0a208";

    private void Start() {
        GetLeaderboard();
    }

    public void GetLeaderboard () {
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) => 
        {
            int loopLength = (msg.Length < names.Count) ? msg.Length : names.Count;
            for (int i = 0; i < names.Count; ++i)
            {
                names[i].text = msg[i].Username;
                scores[i].text = msg[i].Score.ToString();
            }
        }));
    }

    public void SetLeaderboardEntry(string username, int score)
    {
        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey, username, score,
        ((msg) => 
        {
            username.Substring(0,3);
            GetLeaderboard();
        }));
    }
}
