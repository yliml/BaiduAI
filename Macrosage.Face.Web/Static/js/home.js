var app = new Vue({
    el: "#app",
    data: {
        activeAccordionIndex: 0,
        accordionItem: [{
            title: "语音技术",
            items: [{
                icon: "speech-asr.png",
                title: "语音识别",
                intro: "高精度的语音识别服务，融合百度领先的自然语言处理技术，支持多场景智能语音交互",
                href: "/speech"
            }, {
                icon: "speech-tts.png",
                title: "语音合成",
                intro: "基于业界领先的深度神经网络技术，提供流畅自然的语音合成服务，让您的应用开口说话",
                href: "/speech/tts"
            }, {
                icon: "speech-wake.png",
                title: "语音唤醒",
                intro: "支持特定语音指令唤醒，唤醒的同时执行指令操作，轻量级，低功耗，可自定义",
                href: "/speech/wake"
            }]
        }, {
            title: "视觉技术",
            items: [{
                icon: "image-word.png",
                title: "文字识别",
                intro: "提供多种场景下精准的图像文字识别技术服务，提升输入效率，优化用户体验",
                href: "/ocr"
            }, {
                icon: "image-face.png",
                title: "人脸识别",
                intro: "提供快速准确的人脸检测、关键点定位、人脸1：1比对、人脸1：N识别、活体检测等能力",
                href: "/face"
            }, {
                icon: "image-auditing.png",
                title: "图像审核",
                intro: "识别图片中的涉黄、涉暴涉恐、政治敏感、微商广告、恶心等内容，节省审核人力",
                href: "/imagecensoring"
            }, {
                icon: "image-recognition.png",
                title: "图像识别",
                intro: "基于深度学习及大规模图像训练，准确识别图片中的物体类别、位置、置信度等综合信息",
                href: "/imagerecognition"
            }, {
                icon: "image-search.png",
                title: "图像搜索",
                intro: "以图搜图，在指定图库中搜索出相同或相似的图片",
                href: "/imagesearch"
            }]
        }, {
            title: "视频技术",
            items: [{
                icon: "video-vca.png",
                title: "视频内容分析",
                intro: "对视频进行语音、文字、人脸、物体、场景多维度分析，输出视频泛标签",
                href: "/video/vca"
            }, {
                    icon: "video-vcs.png",
                title: "视频封面选取",
                intro: "智能选取静态或动态画面作为视频封面",
                href: "/video/vcs"
            }, {
                    icon: "video-vcc.png",
                title: "视频比对检索",
                intro: "通过图像或者视频片段，快速搜索所属视频",
                href: "/video/vcc"
            }, {
                    icon: "video-vcr.png",
                title: "视频内容审核",
                intro: "识别视频中的涉黄、涉暴涉恐、政治敏感、广告、自定义黑库等内容",
                href: "/video/vcr"
            }]
        }, {
            title: "增强现实",
            items: [{
                icon: "ar.png",
                title: "百度AR平台",
                intro: "提供AR SDK及内容制作工具，让APP可快速集成AR能力",
                href: "http://ar.baidu.com/m/"
            }]
        }, {
            title: "自然语言",
            items: [{
                icon: "nlpc.png",
                title: "语言处理基础技术",
                intro: "国际领先的自然语言处理技术，提供丰富强大的语义分析能力",
                href: "/nlp"
            }, {
                    icon: "text-auditing.png",
                title: "文本审核",
                intro: "识别过滤垃圾、广告、反动、色情等非法UGC内容",
                href: "/textcensoring"
            }, {
                    icon: "unit.png",
                title: "理解与交互技术UNIT",
                intro: "搭载业界领先的需求理解、对话控制及底层的自然语言处理能力，快速构建机器人",
                href: "/unit"
            }, {
                    icon: "translation.png",
                title: "百度翻译开放平台",
                intro: "提供28种语言高质量翻译服务，覆盖中、英、日、韩、俄、葡等热门语种",
                href: "http://fanyi-api.baidu.com"
            }]
        }, {
            title: "数据智能",
            items: [{
                icon: "data-analyze.png",
                title: "数据收集与处理",
                intro: "多系统多模式的数据传输、统一的批量及流式数据处理",
                href: "http://di.baidu.com/#products"
            }, {
                    icon: "data-analysis-search.png",
                title: "数据分析与检索",
                intro: "大数据多维分析、检索、可视化及在线计算服务",
                href: "http://di.baidu.com/#products"
            }, {
                    icon: "data-apply.png",
                title: "数据统计与应用",
                intro: "网站、APP、实体门店的全域数据分析工具及个性化推荐能力",
                href: "http://di.baidu.com/#products"
            }, {
                    icon: "audience.png",
                title: "受众定位与触达",
                intro: "挖掘目标顾客及商家，预测销售商机，提供群体报告服务",
                href: "http://di.baidu.com/#products"
            }, {
                    icon: "marketing.png",
                title: "营销辅助分析",
                intro: "洞察市场及消费者信息，指导企业线上线下营销活动",
                href: "http://di.baidu.com/#products"
            }, {
                    icon: "risk-control.png",
                title: "风控与反欺诈",
                intro: "基于用户行为特征，提供风险识别、风险定价、精准营销、甄别欺诈等服务",
                href: "http://di.baidu.com/#products"
            }, {
                    icon: "public-option.png",
                title: "舆情监控分析",
                intro: "全方位分析互联网舆论，实时监控舆情动态，追溯事件脉络",
                href: "http://di.baidu.com/#products"
            }]
        }, {
            title: "知识图谱",
            items: [{
                icon: "cognitive.png",
                title: "知识理解",
                intro: "基于知识图谱丰富的数据体系，提供对文本语义中实体、概念等深度理解解析能力",
                href: "/cognitive"
            }, {
                    icon: "schema.png",
                title: "知识图谱Schema",
                intro: "定义知识图谱数据模型及用以描述物理世界的词汇体系，规范结构化数据的表达",
                href: "/kg/schema"
            }]
        }, {
            title: "深度学习",
            items: [{
                icon: "paddle.png",
                title: "PaddlePaddle",
                intro: "开源、易用的分布式深度学习平台",
                href: "http://paddlepaddle.org/"
            }]
        }, {
            title: "开放数据集",
            items: [{
                icon: "data-broad.png",
                title: "开放数据集",
                intro: "帮助开发者快速训练自己的人工智能模型及算法",
                href: "/broad"
            }]
        }]
    },
    mounted: function () { },
    methods: {
        getAccordionContentStyle: function (t) {
            return {
                height: this.activeAccordionIndex === t ? 9.3333 * this.accordionItem[t].items.length + "rem" : 0
            }
        },
        handleCollapse: function (t) {
            t !== this.activeAccordionIndex ? this.activeAccordionIndex = t : this.activeAccordionIndex = -
                1
        }
    }
});