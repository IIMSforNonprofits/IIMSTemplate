class DetailView extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <div className="DetailView">I am a DetailView Modal.
            </div>
            /* Example of a modal
             * import React from 'react';

                const Modal = (props) => {
                  const showHideClassName = props.show ? "modal display-block" : 'modal display-none';

                  return (
                    <div className={showHideClassName}>
                      <div className="modal-main">
                        <button onClick={props.handleClose}>X</button>
                        {props.children}
                      </div>
                    </div>
                  )
                }

                export default Modal;
             */
        );
    }
}

export DetailView;