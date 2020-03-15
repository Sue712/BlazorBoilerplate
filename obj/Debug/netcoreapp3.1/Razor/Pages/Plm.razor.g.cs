#pragma checksum "C:\!dev\jikyung\HomePage_Blazor\JikyungHomePage_JKPDM\Pages\Plm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83abe16099592cb8165bccc66b949bd0012da7d7"
// <auto-generated/>
#pragma warning disable 1591
namespace JikyungHomePage_JKPDM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\!dev\jikyung\HomePage_Blazor\JikyungHomePage_JKPDM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\!dev\jikyung\HomePage_Blazor\JikyungHomePage_JKPDM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\!dev\jikyung\HomePage_Blazor\JikyungHomePage_JKPDM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\!dev\jikyung\HomePage_Blazor\JikyungHomePage_JKPDM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\!dev\jikyung\HomePage_Blazor\JikyungHomePage_JKPDM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\!dev\jikyung\HomePage_Blazor\JikyungHomePage_JKPDM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\!dev\jikyung\HomePage_Blazor\JikyungHomePage_JKPDM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\!dev\jikyung\HomePage_Blazor\JikyungHomePage_JKPDM\_Imports.razor"
using JikyungHomePage_JKPDM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\!dev\jikyung\HomePage_Blazor\JikyungHomePage_JKPDM\_Imports.razor"
using JikyungHomePage_JKPDM.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Plm")]
    public partial class Plm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .fontLayout {
        font-size: 20px;
        line-height: 37px;
    }

    .all-facilities .single-facilities .content .title {
        font-size: 21px;
        line-height: 33px;
        padding-top: 25px;
    }

    .all-facilities .single-facilities {
        pointer-events: none;
    }
    .home3-device-banner wow fadeInRight animated odd {
        margin-left: 100px;
    }

    .home3-device-banner wow fadeInRight animated even {
        margin-right: 100px;
    }
    .item-bounce img {
        height: 500px;
        width :  700px;
    }
</style>

");
            __builder.AddMarkupContent(1, @"<section class=""home2-hero-area"">
    <div class=""home2-hero-banner wow fadeInRight animated"" data-wow-delay=""00ms"" data-wow-duration=""1500ms""><img class=""item-bounce"" src=""../img/company-logo/plmmain.png"" style=""width:1920px; height:800px;"" alt></div>
    <div class=""home2-hero-container"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-7 col-12"">
                <div class=""home2-hero-content"">
                    <h2 class=""title"">PLM</h2>
                </div>
            </div>
        </div>
    </div>
</section>

");
            __builder.AddMarkupContent(2, @"<section class=""home5-feature-area"" style=""padding-bottom  : 30px;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""section-title"" style=""margin-bottom :0px;"">
                <h5 class=""title"" style=""font-size: 41px; padding: 0px 0px 30px; margin: 0px 0 37px;"">
                    PLM (Product Lifecycle Management)
                </h5>
            </div>
        </div>
        <div class=""row justify-content-center"">
            <p class=""text fontLayout"">
                제품의 기획/수주에서 설계,생산,판매,A/S에 이르는 제품 개발 과정의 모든 데이터(도면/기술문서/BOM 등) 을 통합적으로 관리하며 제품개발 전 과정의 Process(프로젝트/도면작성/설계변경) 를 최적화 하여
                개발기간단축, 비용절감, 품질향상으로 경쟁력을 강화 합니다.
            </p>
        </div>
        <div class=""row"" style=""margin-top :30px;"">
            <div class=""col-lg-8 offset-lg-2 col-12"" style=""margin-left: 100px;"">
                <div class=""home5-tutorial-video"">
                    <img src=""../img/company-logo/plmgraph.png"" style=""width:900px; height:400px;"" alt>
                </div>
            </div>
        </div>
    </div>
</section>

");
            __builder.AddMarkupContent(3, "<section class=\"home2-built-with-area\">\r\n    <div class=\"home2-built-bg wow fadeInRight animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\"><img src=\"img/product-showcase/built-bg.png\" alt style=\"margin-left:700px; left: 0px;\"></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"home2-built-with-content\">\r\n                    <div class=\"h4eqa-experience\">\r\n                        <h2 class=\"h4-section-title\"> 수주/제품정보관리</h2>\r\n                        <div class=\"facilities-container\">\r\n                            <div class=\"container\">\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-lg-12 col-md-6 col-sm-12 col-12 wow fadeIn animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\">\r\n                                        <div class=\"all-facilities\">\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">수주 및 제품 정보 기준으로 관련 문서, 도면, 일정, 설계변경요청(ECR), 설계변경통보(ECO) 정보를 관리 </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        미리 문서 분류체계 및 프로젝트 일정 탬플릿을 등록 하여 수주 및 제품 정보 등록 시 자동 생성\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        수주 및 제품 정보 별로 검색 용이\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"home3-device-banner wow fadeInRight animated odd\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\" style=\"margin-left:180px;\">\r\n                    <img class=\"item-bounce\" src=\"../img/company-logo/orderproduct.png\" alt>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
            __builder.AddMarkupContent(4, "<section class=\"home2-built-with-area\">\r\n    <div class=\"home2-built-bg wow fadeInLeft animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\"><img src=\"img/product-showcase/built-bg.png\" alt></div>\r\n    <div class=\"home2-built-banner wow fadeInLeft animated even\" data-wow-delay=\"900ms\" data-wow-duration=\"1500ms\"><img class=\"item-bounce\" src=\"../img/company-logo/alldoc.png\" alt></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6 offset-lg-6 col-md-6 offset-md-6 col-12\">\r\n                <div class=\"home2-built-with-content\">\r\n                    <div class=\"h4eqa-experience\">\r\n                        <h2 class=\"h4-section-title\">통합문서관리</h2>\r\n                        <div class=\"facilities-container\">\r\n                            <div class=\"container\">\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-lg-12 col-md-6 col-sm-12 col-12 wow fadeIn animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\">\r\n                                        <div class=\"all-facilities\">\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">     업무과정에서 발생하는 각종 문서, 도면 정보를 체계적으로 관리할 수 있는 기능 제공</h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        도면, 문서 등록/검색, 등록 문서 미리보기, 수정/변경, 복사/이동, 변경 이력 관리, 연계 문서 관리\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        3D 모델링 정보(구조, 속성, 파일) 관리 및 정보 확인(3D Viewer) 가능\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            __builder.AddMarkupContent(5, "<section class=\"home2-built-with-area\">\r\n    <div class=\"home2-built-bg wow fadeInRight animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\"><img src=\"img/product-showcase/built-bg.png\" alt style=\"margin-left:700px; left: 0px;\"></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"home2-built-with-content\">\r\n                    <div class=\"h4eqa-experience\">\r\n                        <h2 class=\"h4-section-title\"> 설계변경관리</h2>\r\n                        <div class=\"facilities-container\">\r\n                            <div class=\"container\">\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-lg-12 col-md-6 col-sm-12 col-12 wow fadeIn animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\">\r\n                                        <div class=\"all-facilities\">\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">  설계변경요청(ECR)에 따른 설계변경통보(ECO) 관리 기능</h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        변경 요청 및 통보 프로세스 시에 자동으로 메일을 통하여 담당자에게 자동 알림 제공\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"home3-device-banner wow fadeInRight animated odd\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\" style=\"margin-left:180px;\">\r\n                    <img class=\"item-bounce\" src=\"../img/company-logo/changedesign.png\" alt>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            __builder.AddMarkupContent(6, "<section class=\"home2-built-with-area\">\r\n    <div class=\"home2-built-bg wow fadeInLeft animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\"><img src=\"img/product-showcase/built-bg.png\" alt></div>\r\n    <div class=\"home2-built-banner wow fadeInLeft animated even\" data-wow-delay=\"900ms\" data-wow-duration=\"1500ms\"><img class=\"item-bounce\" src=\"../img/company-logo/approval.png\" alt></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6 offset-lg-6 col-md-6 offset-md-6 col-12\">\r\n                <div class=\"home2-built-with-content\">\r\n                    <div class=\"h4eqa-experience\">\r\n                        <h2 class=\"h4-section-title\">전자결재 및 배포관리</h2>\r\n                        <div class=\"facilities-container\">\r\n                            <div class=\"container\">\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-lg-12 col-md-6 col-sm-12 col-12 wow fadeIn animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\">\r\n                                        <div class=\"all-facilities\">\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        문서, 도면을 확정(Release, 동결) 하기 위한 전자결재 와 문서, 도면을 배포하기 위한 전자결재 기능 제공\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        결재 진행 현황 및 결재 이력 확인 가능\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        문서, 도면을 배포처(관련 부서, 협력업체 등)에 배포 기간, 배포 권한(보기, 인쇄, 다운로드 등)으로 배포 하는 기능 제공\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        전자 결재 및 배포 시 결재선/배포선 에 있는 담당자에게 알림(Notify) 이메일 발송(선택사항)\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            __builder.AddMarkupContent(7, "<section class=\"home2-built-with-area\">\r\n    <div class=\"home2-built-bg wow fadeInRight animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\"><img src=\"img/product-showcase/built-bg.png\" alt style=\"margin-left:700px; left: 0px;\"></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"home2-built-with-content\">\r\n                    <div class=\"h4eqa-experience\">\r\n                        <h2 class=\"h4-section-title\"> CAD 통합 도구</h2>\r\n                        <div class=\"facilities-container\">\r\n                            <div class=\"container\">\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-lg-12 col-md-6 col-sm-12 col-12 wow fadeIn animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\">\r\n                                        <div class=\"all-facilities\">\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        다양한 CAD 툴과 직접 연계하여 정보를 활용할 수 있는 기능\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        파일명 / 속성 일괄 편집, 도번 채번, 도면 변환(DWG, PDF) 기능\r\n\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        Local(개인, 파일서버) 파일 가져오기, PLM 시스템에서 가져오기, Part List/BOM List 내보내기 기능\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"home3-device-banner wow fadeInRight animated odd\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\" style=\"margin-left:180px;\">\r\n                    <img class=\"item-bounce\" src=\"../img/company-logo/cad.png\" alt>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            __builder.AddMarkupContent(8, "<section class=\"home2-built-with-area\">\r\n    <div class=\"home2-built-bg wow fadeInLeft animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\"><img src=\"img/product-showcase/built-bg.png\" alt></div>\r\n    <div class=\"home2-built-banner wow fadeInLeft animated even\" data-wow-delay=\"900ms\" data-wow-duration=\"1500ms\"><img class=\"item-bounce\" src=\"../img/company-logo/cadviewer.png\" alt></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6 offset-lg-6 col-md-6 offset-md-6 col-12\">\r\n                <div class=\"home2-built-with-content\">\r\n                    <div class=\"h4eqa-experience\">\r\n                        <h2 class=\"h4-section-title\">CAD Viewer</h2>\r\n                        <div class=\"facilities-container\">\r\n                            <div class=\"container\">\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-lg-12 col-md-6 col-sm-12 col-12 wow fadeIn animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\">\r\n                                        <div class=\"all-facilities\">\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        다양한 2D / 3D CAD File Format 지원 및 강력한 검토/활용 기능\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        치수기능 및 마크업, 단면 및 분해도, 모델링 비교 기능\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            __builder.AddMarkupContent(9, "<section class=\"home2-built-with-area\">\r\n    <div class=\"home2-built-bg wow fadeInRight animated \" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\"><img src=\"img/product-showcase/built-bg.png\" alt style=\"margin-left:700px; left: 0px;\"></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"home2-built-with-content\">\r\n                    <div class=\"h4eqa-experience\">\r\n                        <h2 class=\"h4-section-title\">\r\n                            배포커뮤니티\r\n                        </h2>\r\n                        <div class=\"facilities-container\">\r\n                            <div class=\"container\">\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-lg-12 col-md-6 col-sm-12 col-12 wow fadeIn animated\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\">\r\n                                        <div class=\"all-facilities\">\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        배포(협력업체) 와 업무 협업, 정보 공유를 위해 커뮤니티를 제공\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        배포 커뮤니티로 등록된 사용자만 접근이 가능하며 별도의 시스템으로 제공\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"single-facilities\">\r\n                                                <div class=\"icon-box\">\r\n                                                    <span class=\"icon\"><i class=\"fal fa-share-alt\"></i></span>\r\n                                                </div>\r\n                                                <div class=\"content\">\r\n                                                    <h5 class=\"title\">\r\n                                                        배포 커뮤니티로 배포되는 문서, 도면은 배포 권한(보기/인쇄/다운로드) 및 배포 기한을 지정하여 통제\r\n                                                    </h5>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"home3-device-banner wow fadeInRight animated odd\" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\" style=\"margin-left:180px;\">\r\n                    <img class=\"item-bounce\" src=\"../img/company-logo/release.png\" alt>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
