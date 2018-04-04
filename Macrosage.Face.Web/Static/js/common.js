$.sunloading = {
    $toast:null,
    htmls: function (message) {
        var temp = '<div class="loadingToast" style="display:none;">\
                <div class="weui-mask_transparent"></div>\
                <div class="weui-toast">\
                    <i class="weui-loading weui-icon_toast"></i>\
                    <p class="weui-toast__content">'+ message+'</p>\
                </div>\
            </div >';
        $("body").append(temp);
    },
    show: function (message) {
        this.htmls(message);
        this.$toast = $('.loadingToast');
        this.$toast.fadeIn(100);
    },
    close: function () {
        this.$toast.fadeOut(100);
        this.$toast.remove();
    }
};