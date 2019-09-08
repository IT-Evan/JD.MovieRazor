JD.MovieRazor

介绍

ASP.NET Core教程示例 - 电影管理项目

软件架构

ASP.NET Core / Razor Pages / EF Core / SQLLocalDB

安装教程

1. 打开项目
Visual Studio打开JD.MovieRazor.sln.
2. 创建数据库
Visual Studio/工具/NuGet包管理器/程序包管理器控制台, 依次执行两条命令:
PM> Add-Migration 'Initial'
PM> Update-Database

可以在Visual Studio/视图/SQL Server对象资源管理器, 查看数据库.
3. 运行项目
F5运行即可.

使用说明

项目功能菜单:
1. Home, 主页.
2. Movies, 电影管理, 增/删/改/查电影信息.
3. Privacy, 隐私策略.

参与贡献

1. Fork 本仓库
2. 新建 Feat_xxx 分支
3. 提交代码
4. 新建 Pull Request
