class Landing extends React.Component {
    constructor(props) {
        super(props);
        this.state = {} // viewSelected = either login as default state or signUp based on viewSwap Method
    }

    // Methods -- 
    // ?componentDidMount -  
    // login - async call to check with identity service - if valid redirect to dashboard component
    // signUp - create user in DB and redirect to the pending page for new users -- add user to identity service
    // viewSwap - button switch between two different views 

    render() {
        return (
            <div className="Landing">I am a signup/sign-in Landing page.
            </div>
            // Displays login by default with a signup button that will change the display feature and allow for sign up
            // Cookies are taken care of already via .net - TODO: check Identity cookie time limit
            // Forgotten password 
            // selecting a role for signUp
        );
    }
}

export Landing;