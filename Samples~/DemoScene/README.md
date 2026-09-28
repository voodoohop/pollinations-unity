# Pollinations Unity demo

1. Import this sample, then open `DemoScene.unity`. It contains a camera and a
   `PollinationsDemo` object; the overlay UI builds itself at runtime.
2. Select the `PollinationsDemo` object and paste a development `sk_...` key from
   https://enter.pollinations.ai/keys into **ApiKey**.
3. Right-click the component header and choose **Run Pollinations demo**.

The demo generates a one-sentence scene description, a 512x512 image of the prompt
(shown in the RawImage), and spoken audio of the sentence (played by the AudioSource).

For a player-funded build, leave `ApiKey` empty, run `PollinationsAuth` with your
publishable `pk_...` App Key, and assign the returned `AccessToken` to
`PollinationsClient.DeviceToken`. Device-flow tokens stay in memory; do not serialize
them or place development keys in a scene, prefab, or build.
