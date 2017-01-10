google.charts.load('current', { 'packages' : ['corechart'] });
google.charts.setOnLoadCallback(drawChart);
function drawChart() {

	var data = google.visualization.arrayToDataTable(chartData);

    var options = {
        title: 'Physician overview',
        slices: {
            0: { color: '#6cb31d' },
            1: { color: '#ffd500' },
            2: { color: '#f30e34' }
        },
	    pieSliceTextStyle: {
		    color: 'black'
	    }
    };

	var chart = new google.visualization.PieChart(document.getElementById('piechart'));

	chart.draw(data, options);
}

$(function() {

	$('.js-open-user-dashboard').find('.form-step-link').on('click', function (e) {
		var username = $(this).text();
		$('.dashboard-popup').fadeIn(200).addClass('opened').find('.inner').html('');
		$('.overlay').fadeIn(300);
		getUserDashboardContent(username);
		e.preventDefault();
	});

});

function getStepProgressClass(progress) {
    if (progress < 50) {
        return ' red';
    } else if (progress < 99) {
        return ' yellow';
    }

    return ' green';
}

function getUserDashboardContent(username) {

	var url = '/handlers/GetPhysicianFormDataOverview.ashx?username=' + username;
	var $loadingContainer = $('.dashboard-popup .inner');

	$.ajax({
		type: 'GET',
		url: url,
		data: { get_param: 'value' },
		dataType: 'json',
		success: function(data) {
			var returnContent = [];
			$.each(data, function(index, element) {
				var stepName = element.Name,
					stepProgress = element.PercentComplete;

				returnContent.push('<div class="row">' +
									'<div class="col-md-6">' +
										'<div class="form-step-link">' + stepName + '</div>' +
									'</div>' +
									'<div class="col-md-6">' +
										'<div class="form-step-progress' + getStepProgressClass(stepProgress) + '">' +
											'<span class="text-percent">' + stepProgress + '%</span>' +
											'<span class="progress-bar"></span>' +
										'</div>' +
									'</div>' +
								'</div>');
			});
			var contentBefore = '<div class="form-block">' +
									'<h1>' + username + ' Dashboard</h1>' +
									'<div class="dashboard-progress">' +
										'<div class="row hidden-sm-down">' +
											'<div class="col-md-6">' +
												'<h5>Step</h5>' +
											'</div>' +
											'<div class="col-md-6">' +
												'<h5 class="centered">Progress</h5>' +
											'</div>' +
										'</div>';
			var contentRepeat = returnContent.join('');
			var contentAfter = '</div></div>';
			$loadingContainer.append(contentBefore + contentRepeat + contentAfter);
			$loadingContainer.find('.form-step-progress').each(function() {
				var $this = $(this);
				var percentNum = $this.find('.text-percent').text().slice(0,-1);
				setTimeout(function() {
					$this.find('.progress-bar').css('width', percentNum + '%');
				}, 500);
			});
		},
		error: function(data) {
			$loadingContainer.html('<div class="error">Sorry, there was some error with the request. Please refresh the page.</div>');
		}
	});

}