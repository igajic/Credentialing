
$(function () {
    $('input:radio').change(function() {

        if ($('#rbtnQuestionAYes').is(':checked') ||
            $('#rbtnQuestionBYes').is(':checked') ||
            $('#rbtnQuestionCYes').is(':checked') ||
            $('#rbtnQuestionDYes').is(':checked') ||
            $('#rbtnQuestionEYes').is(':checked') ||
            $('#rbtnQuestionFYes').is(':checked') ||
            $('#rbtnQuestionGYes').is(':checked') ||
            $('#rbtnQuestionHYes').is(':checked') ||
            $('#rbtnQuestionIYes').is(':checked') ||
            $('#rbtnQuestionJYes').is(':checked') ||
            $('#rbtnQuestionKYes').is(':checked') ||
            $('#rbtnQuestionLNo').is(':checked') ||
            $('#rbtnQuestionMNo').is(':checked')) {

            $('#pnlDetails').removeClass('hidden');

        } else {
            $('#pnlDetails').addClass('hidden');
        }
    });
});