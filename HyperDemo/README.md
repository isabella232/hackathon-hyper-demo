# Hyper Demo app for Weavy Hackathon 2019

A simple demo web app demonstrating a Weavy integration.

## What's this?
This example is a simple two page web app based on the [Hyper Admin Template](https://themes.getbootstrap.com/product/hyper-responsive-admin-dashboard-template/). The main purpose of this demo is to show how an integration to Weavy in a real world web app could look like. And above all, how do you implement it! 

The code is based on the article on our Playground, [A Complete Example](https://docs.weavy.com/playground/project).

## What will I learn?

- How to use SSO (Single Sign On) using Google Authentcation
- How to integrate the Weavy Messenger
- How to show notifications from Weavy
- How to embed a Files App to a page

## Installation

1. Clone or fork this repo
2. The web app is setup to use Google Auth for authentication. Here we are using a demo Client ID and Secret for demo purposes. The demo Google api credentials is setup to work on https://localhost:44350/ as a redirect url. Feel free to use this when testing this out but make sure to create your own credentials if you plan to deploy this to another url. Otherwise it just won't work.
3. This whole demo is built without any modifications to the Weavy app. This means you can use a Weavy Sandbox that has been setup in [Our Cloud](https://docs.weavy.com/sandbox) to instantly get up and running. Make sure to change the url of the sandbox in Views\Shared\_Layout.cshtml and Views\Customer\Get.cshtml. 

In Views\Shared\_Layout.cshtml, replace:
```
<script src="https://hyper.weavycloud.com/javascript/weavy.js"></script>
```

With:
```
<script src="https://[your url goes here]/javascript/weavy.js"></script>
```

In Views\Customer\Get.cshtml, replace:
```
weavyFiles.addPanel("files-app", "https://hyper.weavycloud.com/apps/5");
```

With:
```
weavyFiles.addPanel("files-app", "[your url goes here]/apps/[id to a files app goes here]");
```

4. Compile and Run!