
/*
微信jsAPI
*/
(function ($, navigator) {
    var ant_js_config;
    var init_ant_js = function () {
        wx.config({
            debug: false,
            appId: ant_js_config.appId,
            timestamp: ant_js_config.timestamp,
            nonceStr: ant_js_config.nonceStr,
            signature: ant_js_config.signature,
            jsApiList: [
                'checkJsApi',
                'onMenuShareTimeline',
                'onMenuShareAppMessage',
                'onMenuShareQQ',
                'onMenuShareWeibo',
                'hideMenuItems',
                'showMenuItems',
                'hideAllNonBaseMenuItem',
                'showAllNonBaseMenuItem',
                'translateVoice',
                'startRecord',
                'stopRecord',
                'onRecordEnd',
                'playVoice',
                'pauseVoice',
                'stopVoice',
                'uploadVoice',
                'downloadVoice',
                'chooseImage',
                'previewImage',
                'uploadImage',
                'downloadImage',
                'getNetworkType',
                'openLocation',
                'getLocation',
                'hideOptionMenu',
                'showOptionMenu',
                'closeWindow',
                'scanQRCode',
                'chooseWXPay',
                'openProductSpecificView',
                'addCard',
                'chooseCard',
                'openCard'
            ]
        });

    }

    $.getJSON('/common/GetJsApi', {
        'url': window.location.href
    }, function (result) {
        if (result) {
            ant_js_config = result;
            init_ant_js();
        }
    });
})(jQuery, navigator;