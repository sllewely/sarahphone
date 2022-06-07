using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class MobileNotifications : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Remove notifications that have already been displayed.
        
        // Create the Android Notification Channel.
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Good morning notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);
        
        
        // Create the Notification.
        var notification = new AndroidNotification();
        notification.Title = "Are you up?";
        notification.Text = "What are we going to do today???";
        notification.FireTime = System.DateTime.Now.AddMinutes(1);

        AndroidNotificationCenter.SendNotification(notification, "channel_id");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
