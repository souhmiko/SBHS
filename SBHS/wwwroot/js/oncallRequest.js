// Function to submit on-call request
async function submitOncallRequest() {
    try {
        // Fetch form data
        const formData = new FormData(document.getElementById('OncallRequestForm'));
        // Make POST request to API endpoint
        const response = await fetch('/api/OncallRequests', {
            method: 'POST',
            body: formData
        });
        // Check if request was successful
        if (response.ok) {
            // Redirect to confirmation page or handle success scenario
            window.location.href = '/ConfirmationLeaveRequestPage';
        } else {
            // Handle error scenario
            console.error('Failed to submit on-call request');
            alert('Failed to submit on-call request');
        }
    } catch (error) {
        console.error('An error occurred:', error);
        alert('An error occurred while submitting on-call request');
    }
}

// Attach click event listener to the submit button
document.getElementById('submitOncallRequestButton').addEventListener('click', submitOncallRequest);