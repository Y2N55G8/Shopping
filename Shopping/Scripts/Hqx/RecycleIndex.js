$("#RecycleList").datagrid({
    url: "/Manage/Hqx/RecycleList",
    loadMsg: "商品信息加载中。。。",
    sortName: "S_no",
    sortOrder: "asc",
    pageSize: 10,
    pageList: [4, 5, 10, 15, 20, 25, 30],
    pagination: true,
    singleSelect: false,
    columns: [[
        { field: 'ck', checkbox: true },
        { field: "S_no", title: "编号", width: 100, sortable: true },
        { field: "S_name", title: "商品名称", width: 300 },
        {
            field: "S_isHot_1", title: "精品", width: 100,
            formatter: function (value, row) {
                if (row.S_isHot == 2) {
                    return "是";
                } else {
                    return "否";
                }
            }
        },
        {
            field: "S_isHot_2", title: "热销", width: 100,
            formatter: function (value, row) {
                if (row.S_isHot == 1) {
                    return "是";
                } else {
                    return "否";
                }
            }
        },
        {
            field: "S_isHot_3", title: "新品", width: 100,
            formatter: function (value, row) {
                if (row.S_isHot == 3) {
                    return "是";
                } else {
                    return "否";
                }
            }
        },
        { field: "S_myprice", title: "价格", width: 100 },
        { field: "S_count", title: "库存", width: 100 },
        {
            field: "S_no_2", title: "管理操作", width: 100,
            formatter: function (value) {
                return "<a href='#' onclick='del()'>删除</a>";
            }
        }
    ]],
    toolbar: "#tb"
});

//假删除
function del() {
    var rows = $('#RecycleList').datagrid("getSelections"); //获取你选择的所有行 
    //循环所选的行
    $.messager.confirm('警告', '此操作将永久删除数据,您确认删除记录吗?', function (r) {
        if (r) {
            for (var i = 0; i < rows.length; i++) {
                var index = $('#RecycleList').datagrid('getRowIndex', rows[i]);//获取某行的行号
                $('#RecycleList').datagrid('deleteRow', index); //通过行号移除该行
            }
        }
    })
}

//搜索
function doSearch() {
    $.ajax({
        url: '/Manage/Hqx/RecycleList',
        type: 'POST',
        data: { text: $("#search-text").val() },
        success: function (result) {
            console.log(result);
            $("#RecycleList").datagrid('loadData', {
                rows: result
            });
        }
    })
}

//$("#btnDelete").click(function () {
//    var rows = $('#RecycleList').datagrid('getSelections');
//    console.log(row);
//    //判断是否勾选
//    //if (rows.length != 0) {
//    //    //提示是否删除
//    //    $.messager.confirm('确认', '您确认想要删除记录吗?', function (r) {
//    //        if (r) {
//    //            //获取勾选行的主键,一次传递到服务器
//    //            var parm;
//    //            //循环勾选的行
//    //            $.each(rows, function (i, n) {
//    //                if (i == 0) {
//    //                    parm = "id=" + n.s_id;
//    //                } else {
//    //                    parm += "$id=" + n.s_id;
//    //                }
//    //            });
//    //            console.log(parm);
//    //            //执行Ajax提交(jquery ajax)
//    //            //$.ajax({
//    //            //    url: '/Admin/Score/Delete',
//    //            //    type: 'POST',
//    //            //    data: parm,
//    //            //    success: function (result) {
//    //            //        //获取到服务器的响应结果
//    //            //    }
//    //            //});
//    //        }
//    //    })
//    //}
//})