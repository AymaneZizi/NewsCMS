/**
 * AdminLTE Demo Menu
 * ------------------
 * You should not use this file in production.
 * This file is for demo purposes only.
 */
(function ($, AdminLTE) {

    /**
     * List of all the available skins
     * 
     * @type Array
     */
    var my_skins = [
      "skin-blue",
      "skin-black",
      "skin-red",
      "skin-yellow",
      "skin-purple",
      "skin-green",
      "skin-blue-light",
      "skin-black-light",
      "skin-red-light",
      "skin-yellow-light",
      "skin-purple-light",
      "skin-green-light"
    ];

    //Create the new tab
    var tab_pane = $("<div />", {
        "id": "control-sidebar-theme-demo-options-tab",
        "class": "tab-pane active"
    });

    //Create the tab button
    var tab_button = $("<li />", { "class": "active" })
            .html("<a href='#control-sidebar-theme-demo-options-tab' data-toggle='tab'>"
                    + "<i class='fa fa-wrench'></i>"
                    + "</a>");

    //Add the tab button to the right sidebar tabs
    $("[href='#control-sidebar-home-tab']")
            .parent()
            .before(tab_button);

    //Create the menu
    var demo_settings = $("<div />");

    //Layout options
    demo_settings.append(
            "<h4 class='control-sidebar-heading'>"
            + "تم ‍‍پیش فرض"
            + "</h4>"
            + "<div class='form-group'>"
            + "<select class='form-control' id='select-theme'>"
            + "<option value=''>انتخاب قالب</option>"
            + "<option value='DarkKnight'>Dark knight</option>"
            + "<option value='BlueSky'>Blue sky</option>"
            + "</select></div>"
            + "<h4 class='control-sidebar-heading'>"
            + "گزینه‌های طرح بندی"
            + "</h4>"
    //Fixed layout
            + "<div class='form-group'>"
            + "<label class='control-sidebar-subheading'>"
            + "<input type='checkbox' data-layout='fixed' class='pull-right'/> "
            + "طرح ثابت"
            + "</label>"
            + "<p>فعال طرح ثابت. شما نمی توانید طرح بندی ثابت و بسته بندی با هم استفاده کنید</p>"
            + "</div>"
    //Boxed layout
            + "<div class='form-group'>"
            + "<label class='control-sidebar-subheading'>"
            + "<input type='checkbox' data-layout='layout-boxed'class='pull-right'/> "
            + "جعبه چیدمان"
            + "</label>"
            + "<p>فعال سازی جعبه چیدمان/p>"
            + "</div>"
    //Sidebar Toggle
            + "<div class='form-group'>"
            + "<label class='control-sidebar-subheading'>"
            + "<input type='checkbox' data-layout='sidebar-collapse' class='pull-right'/> "
            + "تعویض نوار"
            + "</label>"
            + "<p>نوار سمت چپ را باز و بسته کنید</p>"
            + "</div>"
    //Sidebar mini expand on hover toggle
            + "<div class='form-group'>"
            + "<label class='control-sidebar-subheading'>"
            + "<input type='checkbox' data-enable='expandOnHover' class='pull-right'/> "
            + "باز شدن نوار کناری بصورت شناور  "
            + "</label>"
            + "<p>امکان کوچ شدن نوار کناری</p>"
            + "</div>"
    //Control Sidebar Toggle
            + "<div class='form-group'>"
            + "<label class='control-sidebar-subheading'>"
            + "<input type='checkbox' data-controlsidebar='control-sidebar-open' class='pull-right'/> "
            + "تغییر وضعیت منوی سمت راست"
            + "</label>"
            + "<p>باز و بسته کردن منوی کناری/p>"
            + "</div>"
    //Control Sidebar Skin Toggle
            + "<div class='form-group'>"
            + "<label class='control-sidebar-subheading'>"
            + "<input type='checkbox' data-sidebarskin='toggle' class='pull-right'/> "
            + "تغییر منوی سمت راست"
            + "</label>"
            + "<p>تغییر وضعیت بین منوی طرح بندی</p>"
            + "</div>"
            );
    var skins_list = $("<ul />", { "class": 'list-unstyled clearfix' });

    //Dark sidebar skins
    var skin_blue =
            $("<li />", { style: "float:left; width: 33.33333%; padding: 5px;" })
            .append("<a href='javascript:void(0);' data-skin='skin-blue' style='display: block; box-shadow: 0 0 3px rgba(0,0,0,0.4)' class='clearfix full-opacity-hover'>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 7px; background: #367fa9;'></span><span class='bg-light-blue' style='display:block; width: 80%; float: left; height: 7px;'></span></div>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 20px; background: #222d32;'></span><span style='display:block; width: 80%; float: left; height: 20px; background: #f4f5f7;'></span></div>"
                    + "</a>"
                    + "<p class='text-center no-margin'>آبی</p>");
    skins_list.append(skin_blue);
    var skin_black =
            $("<li />", { style: "float:left; width: 33.33333%; padding: 5px;" })
            .append("<a href='javascript:void(0);' data-skin='skin-black' style='display: block; box-shadow: 0 0 3px rgba(0,0,0,0.4)' class='clearfix full-opacity-hover'>"
                    + "<div style='box-shadow: 0 0 2px rgba(0,0,0,0.1)' class='clearfix'><span style='display:block; width: 20%; float: left; height: 7px; background: #fefefe;'></span><span style='display:block; width: 80%; float: left; height: 7px; background: #fefefe;'></span></div>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 20px; background: #222;'></span><span style='display:block; width: 80%; float: left; height: 20px; background: #f4f5f7;'></span></div>"
                    + "</a>"
                    + "<p class='text-center no-margin'>تیره</p>");
    skins_list.append(skin_black);
    var skin_purple =
            $("<li />", { style: "float:left; width: 33.33333%; padding: 5px;" })
            .append("<a href='javascript:void(0);' data-skin='skin-purple' style='display: block; box-shadow: 0 0 3px rgba(0,0,0,0.4)' class='clearfix full-opacity-hover'>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 7px;' class='bg-purple-active'></span><span class='bg-purple' style='display:block; width: 80%; float: left; height: 7px;'></span></div>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 20px; background: #222d32;'></span><span style='display:block; width: 80%; float: left; height: 20px; background: #f4f5f7;'></span></div>"
                    + "</a>"
                    + "<p class='text-center no-margin'>بنفش</p>");
    skins_list.append(skin_purple);
    var skin_green =
            $("<li />", { style: "float:left; width: 33.33333%; padding: 5px;" })
            .append("<a href='javascript:void(0);' data-skin='skin-green' style='display: block; box-shadow: 0 0 3px rgba(0,0,0,0.4)' class='clearfix full-opacity-hover'>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 7px;' class='bg-green-active'></span><span class='bg-green' style='display:block; width: 80%; float: left; height: 7px;'></span></div>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 20px; background: #222d32;'></span><span style='display:block; width: 80%; float: left; height: 20px; background: #f4f5f7;'></span></div>"
                    + "</a>"
                    + "<p class='text-center no-margin'>سبز</p>");
    skins_list.append(skin_green);
    var skin_red =
            $("<li />", { style: "float:left; width: 33.33333%; padding: 5px;" })
            .append("<a href='javascript:void(0);' data-skin='skin-red' style='display: block; box-shadow: 0 0 3px rgba(0,0,0,0.4)' class='clearfix full-opacity-hover'>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 7px;' class='bg-red-active'></span><span class='bg-red' style='display:block; width: 80%; float: left; height: 7px;'></span></div>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 20px; background: #222d32;'></span><span style='display:block; width: 80%; float: left; height: 20px; background: #f4f5f7;'></span></div>"
                    + "</a>"
                    + "<p class='text-center no-margin'>Red</p>");
    skins_list.append(skin_red);
    var skin_yellow =
            $("<li />", { style: "float:left; width: 33.33333%; padding: 5px;" })
            .append("<a href='javascript:void(0);' data-skin='skin-yellow' style='display: block; box-shadow: 0 0 3px rgba(0,0,0,0.4)' class='clearfix full-opacity-hover'>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 7px;' class='bg-yellow-active'></span><span class='bg-yellow' style='display:block; width: 80%; float: left; height: 7px;'></span></div>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 20px; background: #222d32;'></span><span style='display:block; width: 80%; float: left; height: 20px; background: #f4f5f7;'></span></div>"
                    + "</a>"
                    + "<p class='text-center no-margin'>زرد</p>");
    skins_list.append(skin_yellow);

    //Light sidebar skins
    var skin_blue_light =
            $("<li />", { style: "float:left; width: 33.33333%; padding: 5px;" })
            .append("<a href='javascript:void(0);' data-skin='skin-blue-light' style='display: block; box-shadow: 0 0 3px rgba(0,0,0,0.4)' class='clearfix full-opacity-hover'>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 7px; background: #367fa9;'></span><span class='bg-light-blue' style='display:block; width: 80%; float: left; height: 7px;'></span></div>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 20px; background: #f9fafc;'></span><span style='display:block; width: 80%; float: left; height: 20px; background: #f4f5f7;'></span></div>"
                    + "</a>"
                    + "<p class='text-center no-margin' style='font-size: 12px'>آبی روشن</p>");
    skins_list.append(skin_blue_light);
    var skin_black_light =
            $("<li />", { style: "float:left; width: 33.33333%; padding: 5px;" })
            .append("<a href='javascript:void(0);' data-skin='skin-black-light' style='display: block; box-shadow: 0 0 3px rgba(0,0,0,0.4)' class='clearfix full-opacity-hover'>"
                    + "<div style='box-shadow: 0 0 2px rgba(0,0,0,0.1)' class='clearfix'><span style='display:block; width: 20%; float: left; height: 7px; background: #fefefe;'></span><span style='display:block; width: 80%; float: left; height: 7px; background: #fefefe;'></span></div>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 20px; background: #f9fafc;'></span><span style='display:block; width: 80%; float: left; height: 20px; background: #f4f5f7;'></span></div>"
                    + "</a>"
                    + "<p class='text-center no-margin' style='font-size: 12px'>آبی روشن</p>");
    skins_list.append(skin_black_light);
    var skin_purple_light =
            $("<li />", { style: "float:left; width: 33.33333%; padding: 5px;" })
            .append("<a href='javascript:void(0);' data-skin='skin-purple-light' style='display: block; box-shadow: 0 0 3px rgba(0,0,0,0.4)' class='clearfix full-opacity-hover'>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 7px;' class='bg-purple-active'></span><span class='bg-purple' style='display:block; width: 80%; float: left; height: 7px;'></span></div>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 20px; background: #f9fafc;'></span><span style='display:block; width: 80%; float: left; height: 20px; background: #f4f5f7;'></span></div>"
                    + "</a>"
                    + "<p class='text-center no-margin' style='font-size: 12px'>بنفش روشن</p>");
    skins_list.append(skin_purple_light);
    var skin_green_light =
            $("<li />", { style: "float:left; width: 33.33333%; padding: 5px;" })
            .append("<a href='javascript:void(0);' data-skin='skin-green-light' style='display: block; box-shadow: 0 0 3px rgba(0,0,0,0.4)' class='clearfix full-opacity-hover'>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 7px;' class='bg-green-active'></span><span class='bg-green' style='display:block; width: 80%; float: left; height: 7px;'></span></div>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 20px; background: #f9fafc;'></span><span style='display:block; width: 80%; float: left; height: 20px; background: #f4f5f7;'></span></div>"
                    + "</a>"
                    + "<p class='text-center no-margin' style='font-size: 12px'>سبز روشن</p>");
    skins_list.append(skin_green_light);
    var skin_red_light =
            $("<li />", { style: "float:left; width: 33.33333%; padding: 5px;" })
            .append("<a href='javascript:void(0);' data-skin='skin-red-light' style='display: block; box-shadow: 0 0 3px rgba(0,0,0,0.4)' class='clearfix full-opacity-hover'>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 7px;' class='bg-red-active'></span><span class='bg-red' style='display:block; width: 80%; float: left; height: 7px;'></span></div>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 20px; background: #f9fafc;'></span><span style='display:block; width: 80%; float: left; height: 20px; background: #f4f5f7;'></span></div>"
                    + "</a>"
                    + "<p class='text-center no-margin' style='font-size: 12px'>قرمز روشن</p>");
    skins_list.append(skin_red_light);
    var skin_yellow_light =
            $("<li />", { style: "float:left; width: 33.33333%; padding: 5px;" })
            .append("<a href='javascript:void(0);' data-skin='skin-yellow-light' style='display: block; box-shadow: 0 0 3px rgba(0,0,0,0.4)' class='clearfix full-opacity-hover'>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 7px;' class='bg-yellow-active'></span><span class='bg-yellow' style='display:block; width: 80%; float: left; height: 7px;'></span></div>"
                    + "<div><span style='display:block; width: 20%; float: left; height: 20px; background: #f9fafc;'></span><span style='display:block; width: 80%; float: left; height: 20px; background: #f4f5f7;'></span></div>"
                    + "</a>"
                    + "<p class='text-center no-margin' style='font-size: 12px;'>زرد روشن</p>");
    skins_list.append(skin_yellow_light);

    demo_settings.append("<h4 class='control-sidebar-heading'>طرح‌ها</h4>");
    demo_settings.append(skins_list);

    tab_pane.append(demo_settings);
    $("#control-sidebar-home-tab").after(tab_pane);

    setup();

    /**
     * Toggles layout classes
     * 
     * @param String cls the layout class to toggle
     * @returns void
     */
    function change_layout(cls) {
        $("body").toggleClass(cls);
        AdminLTE.layout.fixSidebar();
        //Fix the problem with right sidebar and layout boxed
        if (cls == "layout-boxed")
            AdminLTE.controlSidebar._fix($(".control-sidebar-bg"));
        if ($('body').hasClass('fixed') && cls == 'fixed') {
            AdminLTE.pushMenu.expandOnHover();
            AdminLTE.controlSidebar._fixForFixed($('.control-sidebar'));
            AdminLTE.layout.activate();
        }
    }

    /**
     * Replaces the old skin with the new skin
     * @param String cls the new skin class
     * @returns Boolean false to prevent link's default action
     */
    function change_skin(cls) {
        $.each(my_skins, function (i) {
            $("body").removeClass(my_skins[i]);
        });

        $("body").addClass(cls);
        store('skin', cls);
        return false;
    }

    /**
     * Store a new settings in the browser
     * 
     * @param String name Name of the setting
     * @param String val Value of the setting
     * @returns void
     */
    function store(name, val) {
        if (typeof (Storage) !== "undefined") {
            localStorage.setItem(name, val);
        } else {
            alert('Please use a modern browser to properly view this template!');
        }
    }

    /**
     * Get a prestored setting
     * 
     * @param String name Name of of the setting
     * @returns String The value of the setting | null
     */
    function get(name) {
        if (typeof (Storage) !== "undefined") {
            return localStorage.getItem(name);
        } else {
            alert('Please use a modern browser to properly view this template!');
        }
    }

    /**
     * Retrieve default settings and apply them to the template
     * 
     * @returns void
     */
    function setup() {
        var tmp = get('skin');
        if (tmp && $.inArray(tmp, my_skins))
            change_skin(tmp);

        //Add the change skin listener
        $("[data-skin]").on('click', function (e) {
            e.preventDefault();
            change_skin($(this).data('skin'));
        });

        //Add the layout manager
        $("[data-layout]").on('click', function () {
            change_layout($(this).data('layout'));
        });

        $("[data-controlsidebar]").on('click', function () {
            change_layout($(this).data('controlsidebar'));
            var slide = !AdminLTE.options.controlSidebarOptions.slide;
            AdminLTE.options.controlSidebarOptions.slide = slide;
            if (!slide)
                $('.control-sidebar').removeClass('control-sidebar-open');
        });

        $("[data-sidebarskin='toggle']").on('click', function () {
            var sidebar = $(".control-sidebar");
            if (sidebar.hasClass("control-sidebar-dark")) {
                sidebar.removeClass("control-sidebar-dark")
                sidebar.addClass("control-sidebar-light")
            } else {
                sidebar.removeClass("control-sidebar-light")
                sidebar.addClass("control-sidebar-dark")
            }
        });

        $("[data-enable='expandOnHover']").on('click', function () {
            $(this).attr('disabled', true);
            AdminLTE.pushMenu.expandOnHover();
            if (!$('body').hasClass('sidebar-collapse'))
                $("[data-layout='sidebar-collapse']").click();
        });

        // Reset options
        if ($('body').hasClass('fixed')) {
            $("[data-layout='fixed']").attr('checked', 'checked');
        }
        if ($('body').hasClass('layout-boxed')) {
            $("[data-layout='layout-boxed']").attr('checked', 'checked');
        }
        if ($('body').hasClass('sidebar-collapse')) {
            $("[data-layout='sidebar-collapse']").attr('checked', 'checked');
        }

    }


    /*--mn change theme--*/
    $("#select-theme").change(function () {
        if ($(this).val() != "") {
            $.ajax({
                url: location.origin + '/membership/changetheme?themeName=' + $(this).val(),
                success: function (e) {
                    if (e.Status) {
                        notification.show("تم با موفقیت تغییر کرد");
                        closeModal();
                        setTimeout(function () { location.reload() }, 1000);
                    }
                }
            })
        }
    });


})(jQuery, $.AdminLTE);