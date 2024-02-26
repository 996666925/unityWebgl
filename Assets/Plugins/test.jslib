mergeInto(LibraryManager.library,
    {

        Hello: function ()
        {
            window.alert("Hello, world!");
        },

        HelloString: function (str)
        {
            var msg = Pointer_stringify(str)
            window.ReactNativeWebView.postMessage(msg)
        },

        HelloFloat: function ()
        {
            return 1;
        },
    });