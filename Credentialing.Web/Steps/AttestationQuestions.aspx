<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AttestationQuestions.aspx.cs" Inherits="Credentialing.Web.Steps.AttestationQuestions"  MasterPageFile="../Main.Master"%>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<%@ Register TagPrefix="uc" TagName="Attachments" Src="~/Usercontrols/RenderAttachments.ascx" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>XVI. ATTESTATION QUESTIONS</h1>
    <br />
    <br />
    <br />
    <br />

    <h1>Coming soon</h1>
    
    <asp:Panel ID="Panel1" runat="server" Visible="False">
	    <asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
        <uc:SidebarProgress ID="SidebarProgress1" runat="server" CurrentStep="14" EnableViewState="false"/>
        
        <div class="form-block">
            <div class="form-heading">
                <h2><strong>16.</strong>ATTESTATION QUESTIONS</h2>
                
                <p>Please answer the following question "yes" or "no". If your answer to questions A through K is "YES,", or if your answer to L or M is "NO," please provide full details on separate sheet.</p>
            </div>
    
            <ul style="list-style: upper-latin">
                <li>
                    Has your license to practice medicine in any jurisdiction, your Drug Enforcement Administration (DEA) registration or any applicable narcotic registration in any jurisdiction ever been denied, limited, restricted, suspended, revoked, not renewed, or subject to probationary conditions, or have you voluntarily or
                    involuntarily relinquished any such license or registration or voluntarily or involuntarily accepted any such actions or conditions, or have you been fined or received a letter of reprimand or is such action pending?
                
                    <asp:RadioButton runat="server" ID="rbtnQuestionAYes" GroupName="QuestionA" Text="Yes*"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionANo" GroupName="QuestionA" Text="No"/>
                </li>
        
                <li>Have you ever been charged, suspended, fined, disciplined, or otherwise sanctioned, subjected to probationary conditions, restricted or excluded, or have you voluntarily or involuntarily relinquished eligibility to provide services or accepted conditions on your eligibility to provide services,
                    for reasons relating to possible incompetence or improper professional conduct, or breach of contract or program conditions, by Medicare, Medicaid, or any public program, or is any such action pending?
                
                    <asp:RadioButton runat="server" ID="rbtnQuestionBYes" GroupName="QuestionB" Text="Yes*"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionBNo" GroupName="QuestionB" Text="No"/>
                </li>
        
                <li>
                    Have your clinical privileges, membership, contractual participation or employment by any medical organization (e.g. hospital medical staff, medical group, independent practice association (IPA), health plan, health maintenance organization (HMO), preffered provider organization (PPO), private payer (including those that contract with public programs),
                    medical society, professional association, medical school faculty position or other health delivery entity or system), ever been denied, suspended, restricted, reduced, subject to probationary or disciplinary conditions, revoked, terminated, or not renewed for possible incompetence, improper professional conduct or breach of contract, or is any such action pending?
                
                    <asp:RadioButton runat="server" ID="rbtnQuestionCYes" GroupName="QuestionC" Text="Yes*"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionCNo" GroupName="QuestionC" Text="No"/>
                </li>
        
                <li>
                    Have you ever surrendered, allowed to expire, voluntarily or involuntarily withdrawn a request for membership or clinical privileges, terminated contractual participation or employment, or resigned from any medical organization (e.g., hospital medical staff, medical group, independent practice association (IPA), health plan, health maintenance organization (HMO),
                    preffered provider organization (PPO), medical society, professional association, medical school faculty position or other health delivery entity or system) while under investigation for possible incompetence or improper professional conduct, or breach of contract, or in return for such an investigation not being conducted, or is any such action pending?
                
                    <asp:RadioButton runat="server" ID="rbtnQuestionDYes" GroupName="QuestionD" Text="Yes*"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionDNo" GroupName="QuestionD" Text="No"/>
                </li>
        
                <li>
                    Have you ever surrendered, voluntarily withdrawn, or been requested or compelled to relinquish your status as a student in good standing in any internship, residency, fellowship, perceptorship, or other clinical education program?
                
                    <asp:RadioButton runat="server" ID="rbtnQuestionEYes" GroupName="QuestionE" Text="Yes*"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionENo" GroupName="QuestionE" Text="No"/>
                </li>
        
                <li>
                    Has your membership or fellowship in any local, county, state, regional, national, or international professional organization ever been revoked, denied, reduced, limited, subjected to probationary conditions, or not renewed, or is any such action pending?
                    <asp:RadioButton runat="server" ID="rbtnQuestionFYes" GroupName="QuestionF" Text="Yes*"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionFNo" GroupName="QuestionF" Text="No"/>
                </li>
        
                <li>
                    Have you been denied certification/recertification by a specialty board, or has your eligibility, certification or recertification status changed (other than changing from eligible to certified)?
                    <asp:RadioButton runat="server" ID="rbtnQuestionGYes" GroupName="QuestionG" Text="Yes*"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionGNo" GroupName="QuestionG" Text="No"/>
                </li>
        
                <li>
                    Have you ever been convicted of any crime (other than a minor traffic violation)?
                    <asp:RadioButton runat="server" ID="rbtnQuestionHYes" GroupName="QuestionH" Text="Yes*"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionHNo" GroupName="QuestionH" Text="No"/>
                </li>
        
                <li>
                    Do you presently use any drugs illegally?
                    <asp:RadioButton runat="server" ID="rbtnQuestionIYes" GroupName="QuestionI" Text="Yes*"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionINo" GroupName="QuestionI" Text="No"/>
                </li>
        
                <li>
                    Have any judgements been entered against you, or settlements been agreed to by you within the last seven (7) years, in professional liability cases, or are there any filed and served professional liability lawsuits/arbitrations against you pending?
                    <asp:RadioButton runat="server" ID="rbtnQuestionJYes" GroupName="QuestionJ" Text="Yes*"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionJNo" GroupName="QuestionJ" Text="No"/>
                </li>
        
                <li>
                    Has your professional liability insurance ever been terminated, not renewed, restricted, or modified (e.g. reduced limits, restricted coverage, surcharged), or have you ever been denied professional liability insurance, or has any professional liability carred provided you with written notice of any intent to deny, cancel, not renew, 
                    or limit your professional liability insurance or its coverage of any procedures?
                    <asp:RadioButton runat="server" ID="rbtnQuestionKYes" GroupName="QuestionK" Text="Yes*"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionKNo" GroupName="QuestionK" Text="No"/>
                </li>
        
                <li>
                    Are you able to perform all the services required by your agreement with, or the professional staff bylaws of, the Healthcare Organization to which you are applying, with or without reasonable accomodation, according to accepted standards of prefessional performance and without posing a direct threat to safety of patients?
                
                    <asp:RadioButton runat="server" ID="rbtnQuestionLYes" GroupName="QuestionL" Text="Yes"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionLNo" GroupName="QuestionL" Text="No*"/>
                </li>
        
                <li>
                    Do you currently have malpractice insurance coverage?
                    <asp:RadioButton runat="server" ID="rbtnQuestionMYes" GroupName="QuestionM" Text="Yes"/>
                    <asp:RadioButton runat="server" ID="rbtnQuestionMNo" GroupName="QuestionM" Text="No*"/>
                </li>
            </ul>
            
            <div class="row">
                <div class="col-md-12">
                    <asp:TextBox ID="tboxDetails" runat="server" TextMode="MultiLine" />
                </div>
            </div>

            
            <hr/>
		    <div class="row">
			    <div class="col-md-6">
				    <asp:Label runat="server" Text="Attach additional sheets if necessary" CssClass="label" />
				    <div class="file-upload">
					    <asp:FileUpload ClientIDMode="Static" runat="server" ID="fuAttachments" AllowMultiple="True"/>
					    <span class="temp-filename"></span>
					    <span class="upload-file-btn"><i class="ico"></i></span>
				    </div>
			    </div>
		    </div>
            
            <hr/>
            <uc:Attachments ID="ucAttachments" runat="server" EnableViewState="False"/>
            
            <div class="row">
                <strong>* Details must be provided; use additional sheet(s) and reference Section XVI</strong>

                <p>
                    I hereby affirm that the information submitted in this Section XVI, Attestation Questions, and any addenda thereto is true, current, correct, and complete to the best of my knowledge and belief and is furnished in good faith. I understand that material omission or misrepresentations may result in denial of my application or termination of my privileges,
                    employment or participation agreement.
                </p>
            </div>
        
        </div>
	    <div class="form-actions">
		    <asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		    <asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	    </div>
    </asp:Panel>
</asp:Content>