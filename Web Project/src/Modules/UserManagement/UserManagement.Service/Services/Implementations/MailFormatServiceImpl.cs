using System.Text.Encodings.Web;
using UserManagement.Service.Dto;
using UserManagement.Service.Services.Interface;

namespace UserManagement.Service.Services.Implementations
{
    public class MailFormatServiceImpl:MailFormatService
    {
        public string getRegisterMailFormat(RegisterDto dto, string redirect_url)
        {
            var format = $@"<table bgcolor='#e0e0e0' cellpadding='0' cellspacing='0' border='0' height='100%' width='100%' style='border-collapse:collapse;border-radius:20px;'>
                                  <tr>
                                    <td>
                                      <center style='width: 100%;'>
                                        <div style='display:none;font-size:1px;line-height:1px;max-height:0px;max-width:0px;opacity:0;overflow:hidden;mso-hide:all;font-family: sans-serif;'>
                                          (Optional)This text will appear in the inbox preview, but not the email body. </div>
                                        <table align='center' border='0' width='600' class='email-container'>
                                          <tr>
                                            <td style='padding: 20px 0; text-align: center'>
                                              <img style='max-width: 30%;' alt='New Company inc' src='data:image/png;base64,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'/>
                                            </td>
                                          </tr>
                                        </table>
                                <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='600' class='email-container'>
                                  <tr>
                                    <td dir='rtl' align='center' valign='top' width='100%' style='padding: 20px;'>
                                      <table align='center' border='0' cellpadding='0' cellspacing='0' width='100%'>
                                        <tr>
                                          <td>
                                            <table align='center' border='0' cellpadding='0' cellspacing='0' width='100%'>
                                              <tr>
                                                <td dir='ltr' valign='top' style='font-family: sans-serif; font-size: 12px; mso-height-rule: exactly; line-height: 20px; color: #464343; padding: 10px; text-align:center;'
                                                  class='center-on-narrow'>
                                                  <p>URL : <a href='http://www.newcompany.com' style='text-decoration: none;'>http://www.newcompany.com/login</a>
                                                  </p>
                                                  <p> Username : <strong><input type='text' value='{dto.email}'/></strong> </p>
                                                  <p> Password : <strong><input type='text' value='{dto.password}'/></strong> </p>
                                                  <table cellspacing='0' cellpadding='0' border='0' class='center-on-narrow' style='text-align:center;display:inline-block;'>
                                                    <tr>
                                                      <td style='background: #222222; text-align: center;padding:10px 30px;'class='button-td'>
                                                        <a href='{HtmlEncoder.Default.Encode(redirect_url)}' style='background: #222222;color: #ffffff; font-family: sans-serif; font-size: 13px; line-height: 1.1; text-align: center; text-decoration: none;font-weight: bold; display:block;'
                                                          class='button-a'> Click here to verify</a></td>
                                                    </tr>
                                                  </table>
                                                </td>
                                              </tr>
                                            </table>
                                          </td>
                                        </tr>
                                      </table>
                                    </td>
                                  </tr>
                                </table>
                                <table cellspacing='0' cellpadding='10' border='0' align='center' bgcolor='#ffffff' width='600' class='email-container'>
                                  <tr>
                                    <td>
                                      <hr style='border:solid #eee 1px;'>
                                    </td>
                                   </tr>
                                </table>
                                <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='600' class='about'>
                                  <tr>
                                    <td dir='rtl' align='center' valign='top' width='100%' style='padding: 20px;'>
                                      <table align='center' border='0' cellpadding='0' cellspacing='0' width='100%'>
                                        <tr>
                                          <td dir='ltr' valign='top' style='font-family: sans-serif; font-size: 12px; mso-height-rule: exactly; line-height: 20px; color: #464343; padding: 10px; text-align:center;'
                                            class='center-on-narrow'>
                                            <h3>Welcome To New Company family</h3>
                                            <p>New Company Inc. a part of Talk Holdings is a specialized cloud technologies services providers and certified ERP solution provider in Nepal. We are focused on executing cloud models for clients. We have for the first time partnered with Oracle + NetSuite, World’s #1 Cloud ERP to bring world class business management suite in Nepal. Headquartered in Kathmandu, Nepal Raindrop has operations across Nepal.
                                                New Company Inc. enables enterprises to become more agile and productive by integrating, implementation and supporting various cloud applications through our professional service model including cloud ERP models for the first time in Nepal by partnering with world's #1 Cloud ERP NetSuite. </p>
                                          </td>
                                        </tr>
                                      </table>
                                    </td>
                                  </tr>
                                </table>
                                <table align='center' width='600' class='email-container'>
                                  <tr>
                                    <td style='padding:10px 10px;width: 100%;font-size: 12px; font-family: sans-serif; mso-height-rule: exactly; line-height:18px; text-align: center; color: #888888;'>
                                      <br>
                                        <br>
                                          Raindrop inc.<br>
                                          <span class='mobile-link--footer'>Shree Niwas, Sanepa, Lalitpur</span> <br>
                                          <br>
                                    </td>
                                  </tr>
                                </table>
                                </center>
                                </td>
                                </tr>
                                </table>";
            //var format = $@"Your password is <b>{dto.password}</b> Confirm your email, Please confirm your account by <a href='{HtmlEncoder.Default.Encode(redirect_url)}'>clicking here</a>.";
            return format;
        }

        public string getChangePasswordMailFormat(string email, string new_pass)
        {
            var format = $@"<table bgcolor='#e0e0e0' cellpadding='0' cellspacing='0' border='0' height='100%' width='100%' style='border-collapse:collapse;border-radius:20px;'>
                                  <tr>
                                    <td>
                                      <center style='width: 100%;'>
                                        <div style='display:none;font-size:1px;line-height:1px;max-height:0px;max-width:0px;opacity:0;overflow:hidden;mso-hide:all;font-family: sans-serif;'>
                                          (Optional)This text will appear in the inbox preview, but not the email body. </div>
                                        <table align='center' border='0' width='600' class='email-container'>
                                          <tr>
                                            <td style='padding: 20px 0; text-align: center'>
                                              <img style='max-width: 30%;' alt='New Company inc' src='data:image/png;base64,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'/>
                                            </td>
                                          </tr>
                                        </table>
                                <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='600' class='email-container'>
                                  <tr>
                                    <td dir='rtl' align='center' valign='top' width='100%' style='padding: 20px;'>
                                      <table align='center' border='0' cellpadding='0' cellspacing='0' width='100%'>
                                        <tr>
                                          <td>
                                            <table align='center' border='0' cellpadding='0' cellspacing='0' width='100%'>
                                              <tr>
                                                <td dir='ltr' valign='top' style='font-family: sans-serif; font-size: 12px; mso-height-rule: exactly; line-height: 20px; color: #464343; padding: 10px; text-align:center;'
                                                  class='center-on-narrow'>
                                                  <p>URL : <a href='http://www.newcompany.com' style='text-decoration: none;'>http://www.newcompany.com/login</a>
                                                  </p>
                                                  <p> Username : <strong><input type='text' value='{email}'/></strong> </p>
                                                  <p> New Password : <strong><input type='text' value='{new_pass}'/></strong> </p>
                                                  <table cellspacing='0' cellpadding='0' border='0' class='center-on-narrow' style='text-align:center;display:inline-block;'>
                                                  </table>
                                                </td>
                                              </tr>
                                            </table>
                                          </td>
                                        </tr>
                                      </table>
                                    </td>
                                  </tr>
                                </table>
                                <table cellspacing='0' cellpadding='10' border='0' align='center' bgcolor='#ffffff' width='600' class='email-container'>
                                  <tr>
                                    <td>
                                      <hr style='border:solid #eee 1px;'>
                                    </td>
                                   </tr>
                                </table>
                                <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='600' class='about'>
                                  <tr>
                                    <td dir='rtl' align='center' valign='top' width='100%' style='padding: 20px;'>
                                      <table align='center' border='0' cellpadding='0' cellspacing='0' width='100%'>
                                        <tr>
                                          <td dir='ltr' valign='top' style='font-family: sans-serif; font-size: 12px; mso-height-rule: exactly; line-height: 20px; color: #464343; padding: 10px; text-align:center;'
                                            class='center-on-narrow'>
                                            <h3>Welcome To NewCompany family</h3>
                                            <p>New Company Inc. a part of Talk Holdings is a specialized cloud technologies services providers and certified ERP solution provider in Nepal. We are focused on executing cloud models for clients. We have for the first time partnered with Oracle + NetSuite, World’s #1 Cloud ERP to bring world class business management suite in Nepal. Headquartered in Kathmandu, Nepal Raindrop has operations across Nepal.
                                                Raindrop Inc. enables enterprises to become more agile and productive by integrating, implementation and supporting various cloud applications through our professional service model including cloud ERP models for the first time in Nepal by partnering with world's #1 Cloud ERP NetSuite. </p>
                                          </td>
                                        </tr>
                                      </table>
                                    </td>
                                  </tr>
                                </table>
                                <table align='center' width='600' class='email-container'>
                                  <tr>
                                    <td style='padding:10px 10px;width: 100%;font-size: 12px; font-family: sans-serif; mso-height-rule: exactly; line-height:18px; text-align: center; color: #888888;'>
                                      <br>
                                        <br>
                                          Raindrop inc.<br>
                                          <span class='mobile-link--footer'>Shree Niwas, Sanepa, Lalitpur</span> <br>
                                          <br>
                                    </td>
                                  </tr>
                                </table>
                                </center>
                                </td>
                                </tr>
                                </table>";
            return format;
        }

        public string getRecoverPasswordMailFormat(RecoverPasswordDto dto, string redirect_url)
        {
            var format = $@"<table bgcolor='#e0e0e0' cellpadding='0' cellspacing='0' border='0' height='100%' width='100%' style='border-collapse:collapse;border-radius:20px;'>
                                  <tr>
                                    <td>
                                      <center style='width: 100%;'>
                                        <div style='display:none;font-size:1px;line-height:1px;max-height:0px;max-width:0px;opacity:0;overflow:hidden;mso-hide:all;font-family: sans-serif;'>
                                          (Optional)This text will appear in the inbox preview, but not the email body. </div>
                                        <table align='center' border='0' width='600' class='email-container'>
                                          <tr>
                                            <td style='padding: 20px 0; text-align: center'>
                                              <img style='max-width: 30%;' alt='new company inc' src='data:image/png;base64,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'/>
                                            </td>
                                          </tr>
                                        </table>
                                <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='600' class='email-container'>
                                  <tr>
                                    <td dir='rtl' align='center' valign='top' width='100%' style='padding: 20px;'>
                                      <table align='center' border='0' cellpadding='0' cellspacing='0' width='100%'>
                                        <tr>
                                          <td>
                                            <table align='center' border='0' cellpadding='0' cellspacing='0' width='100%'>
                                              <tr>
                                                <td dir='ltr' valign='top' style='font-family: sans-serif; font-size: 12px; mso-height-rule: exactly; line-height: 20px; color: #464343; padding: 10px; text-align:center;'
                                                  class='center-on-narrow'>
                                                  <p>URL : <a href='http://www.newcompany.com' style='text-decoration: none;'>http://www.newcompany.com/login</a>
                                                  </p>
                                                  <table cellspacing='0' cellpadding='0' border='0' class='center-on-narrow' style='text-align:center;display:inline-block;'>
                                                    <tr>
                                                      <td style='background: #222222; text-align: center;padding:10px 30px;'class='button-td'>
                                                        <a href='{HtmlEncoder.Default.Encode(redirect_url)}' style='background: #222222;color: #ffffff; font-family: sans-serif; font-size: 13px; line-height: 1.1; text-align: center; text-decoration: none;font-weight: bold; display:block;'
                                                          class='button-a'> Reset Password Here</a></td>
                                                    </tr>
                                                  </table>
                                                </td>
                                              </tr>
                                            </table>
                                          </td>
                                        </tr>
                                      </table>
                                    </td>
                                  </tr>
                                </table>
                                <table cellspacing='0' cellpadding='10' border='0' align='center' bgcolor='#ffffff' width='600' class='email-container'>
                                  <tr>
                                    <td>
                                      <hr style='border:solid #eee 1px;'>
                                    </td>
                                   </tr>
                                </table>
                                <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='600' class='about'>
                                  <tr>
                                    <td dir='rtl' align='center' valign='top' width='100%' style='padding: 20px;'>
                                      <table align='center' border='0' cellpadding='0' cellspacing='0' width='100%'>
                                        <tr>
                                          <td dir='ltr' valign='top' style='font-family: sans-serif; font-size: 12px; mso-height-rule: exactly; line-height: 20px; color: #464343; padding: 10px; text-align:center;'
                                            class='center-on-narrow'>
                                            <h3>Welcome To Raindrop family</h3>
                                            <p>New Company Inc. a part of Talk Holdings is a specialized cloud technologies services providers and certified ERP solution provider in Nepal. We are focused on executing cloud models for clients. We have for the first time partnered with Oracle + NetSuite, World’s #1 Cloud ERP to bring world class business management suite in Nepal. Headquartered in Kathmandu, Nepal Raindrop has operations across Nepal.
                                                New Company Inc. enables enterprises to become more agile and productive by integrating, implementation and supporting various cloud applications through our professional service model including cloud ERP models for the first time in Nepal by partnering with world's #1 Cloud ERP NetSuite. </p>
                                          </td>
                                        </tr>
                                      </table>
                                    </td>
                                  </tr>
                                </table>
                                <table align='center' width='600' class='email-container'>
                                  <tr>
                                    <td style='padding:10px 10px;width: 100%;font-size: 12px; font-family: sans-serif; mso-height-rule: exactly; line-height:18px; text-align: center; color: #888888;'>
                                      <br>
                                        <br>
                                          Raindrop inc.<br>
                                          <span class='mobile-link--footer'>Shree Niwas, Sanepa, Lalitpur</span> <br>
                                          <br>
                                    </td>
                                  </tr>
                                </table>
                                </center>
                                </td>
                                </tr>
                                </table>";
            //var format = $@"Your password is <b>{dto.password}</b> Confirm your email, Please confirm your account by <a href='{HtmlEncoder.Default.Encode(redirect_url)}'>clicking here</a>.";
            return format;
        }
    }
}
